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
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using HRESULT = System.Int32;
using DWORD = System.Int32;
using REFSENSOR_ID = System.Guid;

namespace Interop.Sensors
{
    /// <summary>
    /// Data report interface for an ISensor object
    /// </summary>
    [ComImport, Guid("0AB9DF9B-C4B5-4796-8898-0470706A2E1D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ISensorDataReport
    {
        /// <summary>
        /// Get the timestamp for the data report
        /// </summary>
        /// <param name="timeStamp">The timestamp returned for the data report</param>
        void GetTimestamp(out SYSTEMTIME pTimeStamp);

        /// <summary>
        /// Get a single value reported by the sensor
        /// </summary>
        /// <param name="propKey">The data field ID of interest</param>
        /// <param name="propValue">The data returned</param>
        void GetSensorValue(
            [In] ref PROPERTYKEY pKey,
            [In, Out] PROPVARIANT pValue); // value must be newed before call

        /// <summary>
        /// Get multiple values reported by a sensor
        /// </summary>
        /// <param name="keys">The collection of keys for values to obtain data for</param>
        /// <param name="values">The values returned by the query</param>
        void GetSensorValues(
            [In, MarshalAs(UnmanagedType.Interface)] IPortableDeviceKeyCollection pKeys,
            [Out, MarshalAs(UnmanagedType.Interface)] out IPortableDeviceValues pValues);
    }

    /// <summary>
    /// Events interface for the ISensorManager object
    /// </summary>
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("9B3B0B86-266A-4AAD-B21F-FDE5501001B7")]
    public interface ISensorManagerEvents
    {
        void OnSensorEnter(
            [In, MarshalAs(UnmanagedType.Interface)] ISensor pSensor, 
            [In, MarshalAs(UnmanagedType.U4)] SensorState state);
    }

    /// <summary>
    /// Events interface for the ISensor object
    /// </summary>
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("5D8DCC91-4641-47E7-B7C3-B74F48A6C391")]
    public interface ISensorEvents
    {
        void OnStateChanged(
            [In, MarshalAs(UnmanagedType.Interface)] ISensor sensor,
            [In, MarshalAs(UnmanagedType.U4)] SensorState state);

        void OnDataUpdated(
            [In, MarshalAs(UnmanagedType.Interface)] ISensor sensor,
            [In, MarshalAs(UnmanagedType.Interface)] ISensorDataReport newData);

        void OnEvent(
            [In, MarshalAs(UnmanagedType.Interface)] ISensor sensor,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid eventID,
            [In, MarshalAs(UnmanagedType.Interface)] ISensorDataReport newData);

        void OnLeave([In, MarshalAs(UnmanagedType.LPStruct)] REFSENSOR_ID sensorID);
    }
}
