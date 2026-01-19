//---------------------------------------------------------------------------
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved.
//
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using Interop.Sensors;

namespace BadgeSensorWrapper
{
   

    /// <summary>
    /// LightSensorProvider provides the implementation to convert
    /// the Sensor COM Interop library into a Windows Presentation Framework 
    /// Animatable dependency object.
    /// </summary>
    /// <remarks>
    /// The ambient light sensor provider uses the Windows 7 Sensors COM interface to retrieve
    /// a collection of ambient light sensors and provides the composited value for WPF applications.
    /// 
    /// OnInitialize() is called to enumerate any existing sensors attached to the system. Any new 
    /// sensors are added to the Sensors property. When a new sensor is  found (via a callback from 
    /// the sensor managed object), a callback is attached to the sensor object to notify the provider 
    /// when the sensor value has changed or the sensor has been removed.
    ///
    /// When an individual sensor reports a new data event, the lux light property is retrieved. This
    /// value is normalized across all sensors to create a composite light property. Then the provider
    /// uses time and value thresholding to ensure that the frequency of ambient light value changes
    /// does not adversly affect the application.
    /// </remarks>
    public class LightSensorProvider :
        
        ISensorEvents,
        ISensorManagerEvents
    {
        #region Private Member Variables
      

        /// <summary>
        /// A dictionary matching sensor lux values to the sensor id they originated from.
        /// </summary>
        private Dictionary<Guid, double> _values;

        /// <summary>
        /// The observable collection of sensors that are available on the system.
        /// </summary>
        private ICollection<ISensor> _sensors;

        /// <summary>
        /// A reference to the sensor manager object for accessing sensors
        /// </summary>
        private ISensorManager _manager;

        /// <summary>
        /// The most recent composite sensor lux value used for thresholding sensor input.
        /// </summary>
        private double _lastValue;

        /// <summary>
        /// The most recent time the composite sensor value was updated.
        /// </summary>
        private DateTime _lastUpdateTime = DateTime.MinValue;

        #region Private Static Constants
        /// <summary>
        /// The timespan to animate the property value when a new value is received.
        /// </summary>
        private static readonly TimeSpan AnimationTime = TimeSpan.FromSeconds(0.5);

        /// <summary>
        /// The threshold value as a perceived lux 0 -> 1 value to trigger light changes
        /// </summary>
        private static readonly double DefaultChangeThreshold = 0.05;

        /// <summary>
        /// The default ambient light level of an indoor room, in lux.
        /// </summary>
        private const double DefaultNormalIndoorAmbientLightLevelInLux = 350.0;

        /// <summary>
        /// The amount of time this object will wait by default to update large changes
        /// in the detected ambient light value. Increase this value to make fewer updates,
        /// reduce this value in order to make more updates.
        /// </summary>
        private static readonly TimeSpan DefaultMinimumUpdateDelayTime = TimeSpan.FromSeconds(0.5);

        /// <summary>
        /// The amount of time this object will wait by default to update small changes
        /// in the detected ambient light value. If small changes do not significantly impact the 
        /// application this can safely be made larger.
        /// </summary>
        private static readonly TimeSpan DefaultMaximumUpdateDelayTime = TimeSpan.FromSeconds(4);

        /// <summary>
        /// The maximum reported value of the sensor, in lux.
        /// </summary>
        public const double MaximumSensorReportValue = 100000;
        #endregion
        #endregion

        #region Constructors
        /// <summary>
        /// Construct a new LightSensorProvider.
        /// </summary>
        public LightSensorProvider()
            : base()
        {
            // Construct a new mapping of sensor identifiers to the most recent sensor value.
            // This is used to construct the composite sensor value for all ambient light sensor
            // values available on the system (when there is more than once sensor attached).
            _values = new Dictionary<Guid, double>();

            MinimumUpdateDelayTime = DefaultMinimumUpdateDelayTime;
            MaximumUpdateDelayTime = DefaultMaximumUpdateDelayTime;

        

            // Initialize the sensor collection from the existing set of sensors on the sytsem.
            Initialize();
        }
        #endregion

        /// <summary>
        /// The minimum delay time to update the sensor value. This property is available to reduce
        /// a high processor load due to constantly updating values.
        /// </summary>
        public TimeSpan MinimumUpdateDelayTime
        {
            get;
            set;
        }

        /// <summary>
        /// The minimum delay time to update the sensor value. This property is available to reduce
        /// a high processor load due to constantly updating values.
        /// </summary>
        public TimeSpan MaximumUpdateDelayTime
        {
            get;
            set;
        }

        #region Initialize Functionality
        /// <summary>
        /// Attach to the sensor manager objects and initialize the sensor connection
        /// </summary>
        private void Initialize()
        {
            try
            {
                // get a collection of ambient light sensors from the sensor manager.
                ISensorCollection sensorCollection = null;
                Manager.GetSensorsByType(LightSensorType, out sensorCollection);

                if (sensorCollection != null)
                {
                    AddSensorCollection(sensorCollection);
                }
            }
            catch (COMException ex)
            {
                // failed to interop to the sensor API. The most likely reason is the sensor
                // API isn't supported on this operating system and or sku.
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Private Methods
      
     

        /// <summary>
        /// Gets the median value from an <see cref="ICollection{Double}"/>.
        /// </summary>
        /// <param name="iCollection">The collection of values</param>
        /// <returns>The median value of the collection</returns>
        private static double GetMedianValue(ICollection<double> iCollection)
        {
            if (iCollection.Count > 0)
            {
                double[] values = new double[iCollection.Count];
                iCollection.CopyTo(values, 0);
                Array.Sort<double>(values);

                return (values[values.Length / 2]);
            }
            return 0;
        }

        /// <summary>
        /// Animates the specified dependency property using the specified timeline on the DispatcherObject's dispatch thread.
        /// </summary>
   
        #region Delayed Update Helper Functions
        /// <summary>
        /// Determines if the provided value in lux exceeds the default update threshold.
        /// </summary>
        private bool DoesLuxValueExceedThreshold(double luxValue)
        {
            // if the last value is zero it hasn't been initialized yet, and therefore always reset.
            if (_lastValue == 0)
            {
                return true;
            }

            // lux values are not linear when correlated to human perception, they tend to the
            // following chart:
            //  0     -> 10     Dark
            //  10    -> 300    Dim Indoor
            //  300   -> 800    Normal Indoor
            //  800   -> 10000  Bright Indoor
            //  10000 -> 30000  Overcast Outdoor
            //  30000 -> 100000 Direct sunlight
            //
            // Since the threshold value is based on triggering changes in the user interface,
            // we're going to convert our lux values into a threshold that is based on human 
            // perception. To do this, we're going to use a log10 function.
            double newValue = Math.Log10(luxValue) / Math.Log10(MaximumSensorReportValue);
            double lastValue = Math.Log10(_lastValue) / Math.Log10(MaximumSensorReportValue);

            // return the absolute distance compared to the default thresholding value
            return (Math.Abs(newValue - lastValue) > DefaultChangeThreshold);
        }

        /// <summary>
        /// Determines if the time from the last update has exceeded the default delay to
        /// ensure that the ambient light value doesn't change too frequently.
        /// </summary>
        private bool HasUpdateTimeDelayElapsed(TimeSpan delay)
        {
            return (_lastUpdateTime.Add(delay) < DateTime.UtcNow);
        }

      
       

     
        #endregion

       

        /// <summary>
        /// Sets the specified sensor's lux value and updates the composite value.
        /// </summary>
        private void SetSensorLightLuxValue(Guid sensorId, double value)
        {
            // set the mapping of sensor ids to values to include the new value.
            _values[sensorId] = value;

            // update the composite lighting value and fire a value changed event if
            // the new sensor value exceeds the thresholding in UpdateCompositeSensorValue
         
        }
        #endregion

        #region SensorManager Property
        /// <summary>
        /// Gets the sensor manager COM object interface.
        /// </summary>
        /// <exception cref="COMException">Thrown when the sensor manager is unable to be created.</exception>
        protected ISensorManager Manager
        {
            get
            {
                // Create a new instance of the sensor manager if supported
                // on this operating system.
                if (_manager == null)
                {
                    // the sensor manager may not be available on this platform, so
                    // the creation of the sensor manager object here my throw an exception.
                    // capturing the exception is the most efficient way to determine if the
                    // sensor platform exists and is available.
                    _manager = new SensorManager();

                    // Register for sensor manager event callback events.                    
                    _manager.SetEventSink(this);
                }
                return _manager;
            }
        }
        #endregion

        #region ISensorEvents Members
        /// <summary>
        /// Fired when a sensor object's state is changed.
        /// </summary>
        void ISensorEvents.OnStateChanged(ISensor sensor, SensorState state)
        {
            // for this class, there is no response to an OnStateChanged event. The code
            // below is provided for clarity in implementing your own sensor state change response
            switch (state)
            {
                case SensorState.Ready:
                    // the sensor has come online and is ready to read and write data
                    break;
                case SensorState.AccessDenied:
                    // the sensor access has been revoked. The application should remove
                    // sensor values since the sensor is no longer available.
                    break;
                case SensorState.Error:
                    // a sensor error has occurred 
                    break;
                case SensorState.Initializing:
                    // the sensor is initializing, data is not available.
                    break;
                case SensorState.NotAvailable:
                    // the sensor is not available.
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Fired when sensor data is updated.
        /// </summary>
        void ISensorEvents.OnDataUpdated(ISensor sensor, ISensorDataReport newData)
        {
            PROPVARIANT lightLuxValue = new PROPVARIANT();
            PROPERTYKEY lightLuxKey = SensorPropertyKeys.SENSOR_DATA_TYPE_LIGHT_LUX;

            try
            {
                PROPVARIANT timeValue = new PROPVARIANT();
                PROPERTYKEY timeKey = SensorPropertyKeys.SENSOR_DATA_TYPE_TIMESTAMP;

                try
                {
                    newData.GetSensorValue(ref timeKey, timeValue);

                    if (timeValue.VarType == VarEnum.VT_DATE)
                    {
                        DateTime value = (DateTime)timeValue.Value;
                        System.Diagnostics.Debug.WriteLine("Data event timestamp: " + value.ToString());
                    }

                }
                finally
                {
                    timeValue.Clear();
                }

                try
                {
                    // get the light value in lux property from the sensor
                    newData.GetSensorValue(ref lightLuxKey, lightLuxValue);
                }
                catch (COMException ex)
                {
                    // failed to get the property from the sensor
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }

                // get the property variant object value
                double lightLux = 0.0;
                object lightLuxObject = lightLuxValue.Value;

                if (lightLuxObject != null)
                {
                    // parse the sensor value type, for SENSOR_DATA_TYPE_LIGHT_LUX we only
                    // expect a value of VT_R4 (float) from the sensor driver.
                    switch (lightLuxValue.VarType)
                    {
                        case VarEnum.VT_R4:
                            lightLux = (float)lightLuxValue.Value;
                            break;

                        default:
                            return; // not a valid sensor type, so don't record the value
                    }

                    // Get the sensor id so we can associate the sensor lux value
                    // with a specific sensor id in our collection
                    Guid sensorId = Guid.Empty;
                    try
                    {
                        sensor.GetID(out sensorId);
                    }
                    catch (COMException ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                    }

                    if (sensorId != Guid.Empty)
                    {
                        // Set the sensor light value
                        SetSensorLightLuxValue(sensorId, lightLux);
                    }
                }
            }
            finally
            {
                lightLuxValue.Clear();
            }
        }

        /// <summary>
        /// Fired when a sensor event is received.
        /// </summary>
        void ISensorEvents.OnEvent(ISensor sensor, Guid eventID, ISensorDataReport newData)
        {
            // the sensor has fired a non-data event. This class has no action on a sensor event
        }

        /// <summary>
        /// Fired when a sensor is removed.
        /// </summary>
        void ISensorEvents.OnLeave(Guid sensorId)
        {
            // remove the sensor from the list of active sensor values
            if (_values.ContainsKey(sensorId))
            {
                _values.Remove(sensorId);
            }

            // enumerate through the list of sensors that we have attached
            // to the system to find the sensor that is leaving
            foreach (ISensor sensor in Sensors)
            {
                // get the sensor id to see if it matches the sensor that is being removed.
                Guid id = Guid.Empty;
                try
                {
                    sensor.GetID(out id);
                }
                catch (COMException ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }

                if (id != Guid.Empty && id == sensorId)
                {
                    // if we have found the current sensor, remove it from the collection,
                    // clear the event callback sink, and stop enumerating through the sensors.
                    if (Sensors.Remove(sensor))
                    {
                        break;
                    }
                }
            }

            // re-calculate the composite sensor value now that the sensor
            // has been removed from the system.
          
        }

        #endregion

        #region ISensorManagerEvents Members

        /// <summary>
        /// Fired when a sensor is attached.
        /// </summary>
        void ISensorManagerEvents.OnSensorEnter(ISensor sensor, SensorState state)
        {
            // get the newly arrived sensor type
            Guid sensorType = Guid.Empty;
            try
            {
                sensor.GetType(out sensorType);
            }
            catch (COMException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            // if the sensor type isn't empty and it matches the ambient sensor type,
            // then add the sensor to the current set of sensor values.
            if (sensorType != Guid.Empty && sensorType == LightSensorType)
            {
                AddSensor(sensor);
            }
        }

        #endregion

        #region Freezable Abstract Class Implementation
     
        #endregion

        /// <summary>
        /// Gets the collection of ambient light sensors that are currently active.
        /// </summary>
        public ICollection<ISensor> Sensors
        {
            get
            {
                if (_sensors == null)
                {
                    // Create a sensor collection to keep track of active sensors.
                    _sensors = new Collection<ISensor>();
                }
                return _sensors;
            }
        }

        /// <summary>
        /// Add all sensors from the specified collection as sensor sources for
        /// ambient light. All sensors from this collection are assumed to be
        /// ambient light sensors.
        /// </summary>
        private void AddSensorCollection(ISensorCollection sensorCollection)
        {
            if (sensorCollection != null)
            {
                // get the sensor count
                uint count = 0;

                try
                {
                    sensorCollection.GetCount(out count);
                }
                catch (COMException ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }

                // enumerate through the sensor collection, getting each sensor individually
                for (uint i = 0; i < count; i++)
                {
                    ISensor sensor = null;
                    try
                    {
                        // get the sensor at the current index
                        sensorCollection.GetAt(i, out sensor);
                    }
                    catch (COMException ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                    }

                    if (sensor != null)
                    {
                        // add the sensor to the current collection
                        AddSensor(sensor);
                    }
                }
            }
        }

        /// <summary>
        /// Adds an individual sensor as a sensor source for ambient light. This
        /// sensor is assumed to be an ambient light sensor.
        /// </summary>
        /// <param name="sensor"></param>
        private void AddSensor(ISensor sensor)
        {
            if (sensor != null)
            {
                PROPVARIANT nameValue = new PROPVARIANT();
                PROPERTYKEY nameKey = SensorPropertyKeys.SENSOR_PROPERTY_FRIENDLY_NAME;

                try
                {
                    sensor.GetProperty(ref nameKey, nameValue);

                    if (nameValue.VarType == VarEnum.VT_BSTR)
                    {
                        string value = (string)nameValue.Value;
                        System.Diagnostics.Debug.WriteLine("AddSensor: " + value);
                    }
                }
                finally
                {
                    nameValue.Clear();
                }

                try
                {
                    // register for sensor event callbacks on the sensor device so
                    // we know when the sensor data has changed.
                    sensor.SetEventSink(this);

                    Sensors.Add(sensor);
                }
                catch (COMException ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }

                if (Sensors.Contains(sensor))
                {
                    // get the current sensor state
                    SensorState state = SensorState.Initializing;
                    try
                    {
                        sensor.GetState(out state);
                    }
                    catch (COMException ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                    }

                    switch (state)
                    {
                        case SensorState.Ready:
                            RequestSensorDataReport(sensor);
                            break;

                        case SensorState.AccessDenied:
                            RequestSensorAccess(sensor);
                            break;

                        default:
                            // sensor device state is currently not actionable.
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Query the sensor for any sensor data it has, then update the sensor
        /// data by using the OnDataUpdated callback.
        /// </summary>
        private void RequestSensorDataReport(ISensor sensor)
        {
            if (sensor != null)
            {
                // If the sensor is ready, we can query for the current sensor value
                ISensorDataReport data = null;
                try
                {
                    sensor.GetData(out data);
                }
                catch (COMException ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }

                if (data != null)
                {
                    // Initialize the sensor data value using the callback
                    ((ISensorEvents)this).OnDataUpdated(sensor, data);
                }
            }
        }

        /// <summary>
        /// Surface a sensor dialog to request access to the sensor device. A user may
        /// restrict access to specific sensors due to security and privacy concerns they may have,
        /// depending on what data the sensor provides.
        /// </summary>
        private void RequestSensorAccess(ISensor sensor)
        {
            if (sensor != null)
            {
                ISensorCollection sensors = null;

                // create a sensor collection to request access to the sensor device
                // this will surface a top-level dialog to the user.
                try
                {
                    sensors = new SensorCollection();
                    sensors.Add(sensor);
                }
                catch (COMException ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }

                if (sensors != null)
                {
                    // if available, the application should get the handle to the 
                    // main window for this application.
                    IntPtr windowHandle = IntPtr.Zero;

                    try
                    {
                        // ask the sensor platform to request access from the user from a modal window
                        // if we are able to get the main window for the current application.
                        Manager.RequestPermissions(windowHandle, sensors, true);
                    }
                    catch (COMException ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Returns the Ambient Light Sensor type.
        /// </summary>
        public Guid LightSensorType
        {
            get { return SensorTypes.AmbientLight; }
        }

    
    }
}
