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
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DWORD = System.UInt32;
using HRESULT = System.Int32;
using LOCATION_KEY = Interop.Sensors.PROPERTYKEY;
using SENSOR_ID = System.Guid;
using SENSOR_TYPE_ID = System.Guid;
using WORD = System.UInt16;

namespace Interop.Sensors
{
    #region Enumerations

    public enum ReportStatus
    {
        ReportNotSupported = 0,
        ReportError = 1,
        ReportAccessDenied = 2,
        ReportInitializing = 3,
        ReportRunning = 4
    }

    #endregion

    /// <summary>
    /// The SYSTEMTIME structure represents a date and time using individual members for 
    /// the month, day, year, weekday, hour, minute, second, and millisecond.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEMTIME
    {
        public WORD wYear;
        public WORD wMonth;
        public WORD wDayOfWeek;
        public WORD wDay;
        public WORD wHour;
        public WORD wMinute;
        public WORD wSecond;
        public WORD wMillisecond;

        /// <summary>
        /// Gets the <see cref="DateTime"/> representation of this object.
        /// </summary>
        public DateTime DateTime
        {
            get { return new DateTime(wYear, wMonth, wDay, wHour, wMinute, wSecond, wMillisecond); }
        }

        public static implicit operator DateTime(SYSTEMTIME systemTime)
        {
            return systemTime.DateTime;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture.NumberFormat, "{0:D2}/{1:D2}/{2:D4}, {3:D2}:{4:D2}:{5:D2}.{6}", wMonth, wDay, wYear, wHour, wMinute, wSecond, wMillisecond);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct LOCATION_REPORT_BASE
    {
        public DWORD version;
        public LOCATION_KEY type;
        public DWORD size;
        public SENSOR_ID sensor;
        public SYSTEMTIME creationTime;
        public DWORD flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct LOCATION_SENSOR_INFO
    {
        public SENSOR_ID sensorId;
        public SENSOR_TYPE_ID sensorType;
    }

    #region Location Reports

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("C8B7F7EE-75D0-4DB9-B62D-7A0F369CA456")]
    public interface ILocationReport
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        Guid GetSensorID();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        SYSTEMTIME GetTimestamp();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetValue([In] ref PROPERTYKEY pKey, out PROPVARIANT pValue);
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("7FED806D-0EF8-4F07-80AC-36A0BEAE3134")]
    public interface ILatLongReport : ILocationReport
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new Guid GetSensorID();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new SYSTEMTIME GetTimestamp();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetValue([In] ref PROPERTYKEY pKey, out PROPVARIANT pValue);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        double GetLatitude();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        double GetLongitude();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        double GetErrorRadius();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        double GetAltitude();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        double GetAltitudeError();
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("C0B19F70-4ADF-445D-87F2-CAD8FD711792")]
    public interface ICivicAddressReport : ILocationReport
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new Guid GetSensorID();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new SYSTEMTIME GetTimestamp();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetValue([In] ref PROPERTYKEY pKey, out PROPVARIANT pValue);

        [return: MarshalAs(UnmanagedType.BStr)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        string GetAddressLine1();

        [return: MarshalAs(UnmanagedType.BStr)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        string GetAddressLine2();

        [return: MarshalAs(UnmanagedType.BStr)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        string GetCity();

        [return: MarshalAs(UnmanagedType.BStr)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        string GetStateProvince();

        [return: MarshalAs(UnmanagedType.BStr)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        string GetPostalCode();

        [return: MarshalAs(UnmanagedType.BStr)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        string GetCountryRegion();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        uint GetDetailLevel();
    }

    #endregion

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("AB2ECE69-56D9-4F28-B525-DE1B0EE44237")]
    public interface ILocation
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT RegisterForReport([In, MarshalAs(UnmanagedType.Interface)] ILocationEvents pEvents, [In] ref Guid reportType, [In] uint dwMinReportInterval);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT UnregisterForReport([In] ref Guid reportType);

        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        ILocationReport GetReport([In] ref Guid reportType);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetReportStatus([In] ref Guid reportType, out ReportStatus pStatus);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        DWORD GetReportInterval([In] ref Guid reportType);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT SetReportInterval([In] ref Guid reportType, [In] uint milliseconds);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT RequestPermissions([In] IntPtr hParent, [In] ref Guid pReportTypes, [In] uint count, [In] int fModal);
    }

}
