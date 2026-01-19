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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HRESULT = System.Int32;
using REFSENSOR_CATEGORY_ID = System.Guid;
using REFSENSOR_ID = System.Guid;
using REFSENSOR_TYPE_ID = System.Guid;

namespace Interop.Sensors
{
    static class SensorDataType
    {
        public static PROPERTYKEY SENSOR_DATA_TYPE_ANGLE_DEGREES = PROPERTYKEY.Create("af417aec-4e90-4d56-80eb-8f50dce39b5b", 11);

        public static PROPERTYKEY SENSOR_DATA_TYPE_ACCELERATION_X_G = PROPERTYKEY.Create("3F8A69A2-07C5-4E48-A965-CD797AAB56D5", 2);
        public static PROPERTYKEY SENSOR_DATA_TYPE_ACCELERATION_Y_G = PROPERTYKEY.Create("3F8A69A2-07C5-4E48-A965-CD797AAB56D5", 3);
        public static PROPERTYKEY SENSOR_DATA_TYPE_ACCELERATION_Z_G = PROPERTYKEY.Create("3F8A69A2-07C5-4E48-A965-CD797AAB56D5", 4);
    }

    [ComImport, GuidAttribute("77A1C827-FCD2-4689-8915-9D613CC5FA3E"),ClassInterfaceAttribute(ClassInterfaceType.None)]
    public class SensorManager : ISensorManager
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetSensorsByCategory(
            [In, MarshalAs(UnmanagedType.LPStruct)] REFSENSOR_CATEGORY_ID sensorCategory, 
            [Out, MarshalAs(UnmanagedType.Interface)] out ISensorCollection ppSensorsFound);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetSensorsByType(
            [In, MarshalAs(UnmanagedType.LPStruct)] REFSENSOR_TYPE_ID sensorType,
            [Out, MarshalAs(UnmanagedType.Interface)] out ISensorCollection ppSensorsFound);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void GetSensorByID(
            [In, MarshalAs(UnmanagedType.LPStruct)] REFSENSOR_ID sensorID,
            [Out, MarshalAs(UnmanagedType.Interface)] out ISensor ppSensor);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void SetEventSink(
            [Out, MarshalAs(UnmanagedType.Interface)] ISensorManagerEvents pEvents);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern void RequestPermissions(
            IntPtr hParent,
            [In, MarshalAs(UnmanagedType.Interface)] ISensorCollection pSensors, 
            [In, MarshalAs(UnmanagedType.Bool)] bool modal);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("BD77DB67-45A8-42DC-8D00-6DCF15F8377A")]
    public interface ISensorManager
    {
        /// <summary>
        /// Get a collection of related sensors by category, Ex: Light
        /// </summary>
        /// <param name="sensorCategory">The category of sensors to find</param>
        /// <param name="ppSensorsFound">The collection of sensors found</param>
        void GetSensorsByCategory(
            [In, MarshalAs(UnmanagedType.LPStruct)] REFSENSOR_CATEGORY_ID sensorCategory,
            [Out, MarshalAs(UnmanagedType.Interface)] out ISensorCollection ppSensorsFound);

        /// <summary>
        /// Get sensors by type, Ex: Ambient Light
        /// </summary>
        /// <param name="sensorType">The type of sensors to find</param>
        /// <param name="ppSensorsFound">The collection of sensors found</param>
        void GetSensorsByType(
            [In, MarshalAs(UnmanagedType.LPStruct)] REFSENSOR_TYPE_ID sensorType,
            [Out, MarshalAs(UnmanagedType.Interface)] out ISensorCollection ppSensorsFound);

        /// <summary>
        /// Get a unique instance of a sensor
        /// </summary>
        /// <param name="sensorID">The unique ID of a sensor installed on a system</param>
        /// <param name="ppSensor">The ISensor interface pointer for the sensor found, or null if no sensor was found</param>
        void GetSensorByID(
            [In, MarshalAs(UnmanagedType.LPStruct)] REFSENSOR_ID sensorID,
            [Out, MarshalAs(UnmanagedType.Interface)] out ISensor ppSensor);

        /// <summary>
        /// Subscribe to ISensors events
        /// </summary>
        /// <param name="pEvents">An interface pointer to the callback object created</param>
        void SetEventSink(
            [In, MarshalAs(UnmanagedType.Interface)] ISensorManagerEvents pEvents);

        void RequestPermissions(
            [In] IntPtr parent,
            [In, MarshalAs(UnmanagedType.Interface)] ISensorCollection sensors,
            [In, MarshalAs(UnmanagedType.Bool)] bool modal);
    }
}
