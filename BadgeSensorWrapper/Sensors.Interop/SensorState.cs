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

namespace Interop.Sensors
{
    /// <summary>
    /// Determines the state of the sensor device.
    /// </summary>
    public enum SensorState
    {
        /// <summary>
        /// The device is ready.
        /// </summary>
        Ready = 0,
        /// <summary>
        /// The device is not available.
        /// </summary>
        NotAvailable = 1,
        /// <summary>
        /// No data is available.
        /// </summary>
        NoData,
        /// <summary>
        /// The device is initializing.
        /// </summary>
        Initializing,
        /// <summary>
        /// No permissions exist to access the device.
        /// </summary>
        AccessDenied,
        /// <summary>
        /// The device has encountered an error.
        /// </summary>
        Error
    }
}
