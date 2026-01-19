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

namespace Interop.Sensors
{
    public sealed class SensorEventConstants
    {
        public static readonly Guid EventStateChanged = new Guid(0xBFD96016, 0x6BD7, 0x4560, 0xAD, 0x34, 0xF2, 0xF6, 0x60, 0x7E, 0x8F, 0x81);
        public static readonly Guid EventDataUpdated = new Guid(0x2ED0F2A4, 0x0087, 0x41D3, 0x87, 0xDB, 0x67, 0x73, 0x37, 0x0B, 0x3C, 0x88);

        public static readonly PROPERTYKEY DataUpdated = PROPERTYKEY.Create(new Guid(0x2ED0F2A4, 0x0087, 0x41D3, 0x87, 0xDB, 0x67, 0x73, 0x37, 0x0B, 0x3C, 0x88),0);
        public static readonly PROPERTYKEY ParameterEventId = PROPERTYKEY.Create(new Guid(0x64346E30, 0x8728, 0x4B34, 0xBD, 0xF6, 0x4F, 0x52, 0x44, 0x2C, 0x5C, 0x28), 2);
        public static readonly PROPERTYKEY ParameterState = PROPERTYKEY.Create(new Guid(0x64346E30, 0x8728, 0x4B34, 0xBD, 0xF6, 0x4F, 0x52, 0x44, 0x2C, 0x5C, 0x28), 3);
    }

    /// <summary>
    /// Location Property Key identifiers
    /// </summary>
    public sealed class LocationPropertyKeys
    {
        /// <summary>
        /// The location latitude longitude report.
        /// </summary>
        public static readonly Guid LatLongReportGuid = new Guid(0x7FED806D, 0x0EF8, 0x4f07, 0x80, 0xAC, 0x36, 0xA0, 0xBE, 0xAE, 0x31, 0x34);
        public static readonly Guid CivicAddressReportGuid = new Guid(0xC0B19F70, 0x4ADF, 0x445d, 0x87, 0xF2, 0xCA, 0xD8, 0xFD, 0x71, 0x17, 0x92);
    }

    /// <summary>
    /// Sensor Property Key identifiers
    /// </summary>
    public sealed class SensorPropertyKeys
    {
        /// <summary>
        /// The common Guid used by the property keys.
        /// </summary>
        public static readonly Guid SENSOR_PROPERTY_COMMON_GUID = new Guid(0X7F8383EC, 0XD3EC, 0X495C, 0XA8, 0XCF, 0XB8, 0XBB, 0XE8, 0X5C, 0X29, 0X20);
        /// <summary>
        /// The sensor type property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_TYPE = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 2);
        /// <summary>
        /// The sensor state property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_STATE = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 3);
        /// <summary>
        /// The sensor sampling rate property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_SAMPLING_RATE = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 4);
        /// <summary>
        /// The sensor persistent unique id property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_PERSISTENT_UNIQUE_ID = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 5);
        /// <summary>
        /// The sensor manufacturer property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_MANUFACTURER = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 6);
        /// <summary>
        /// The sensor model property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_MODEL = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 7);
        /// <summary>
        /// The sensor serial number property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_SERIAL_NUMBER = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 8);
        /// <summary>
        /// The sensor friendly name property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_FRIENDLY_NAME = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 9);
        /// <summary>
        /// The sensor description property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_DESCRIPTION = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 10);
        /// <summary>
        /// The sensor connection type property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_CONNECTION_TYPE = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 11);
        /// <summary>
        /// The sensor min report interval property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_MIN_REPORT_INTERVAL = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 12);
        /// <summary>
        /// The sensor current report interval property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_CURRENT_REPORT_INTERVAL = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 13);
        /// <summary>
        /// The sensor change sensitivity property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_CHANGE_SENSITIVITY = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 14);
        /// <summary>
        /// The sensor device id property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_DEVICE_ID = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 15);
        /// <summary>
        /// The sensor accuracy property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_ACCURACY = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 16);
        /// <summary>
        /// The sensor resolution property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_RESOLUTION = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 17);
        /// <summary>
        /// The sensor light response curve property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_PROPERTY_LIGHT_RESPONSE_CURVE = PROPERTYKEY.Create(SENSOR_PROPERTY_COMMON_GUID, 18);

        /// <summary>
        /// The sensor date time property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_TIMESTAMP = PROPERTYKEY.Create(new Guid(0XDB5E0CF2, 0XCF1F, 0X4C18, 0XB4, 0X6C, 0XD8, 0X60, 0X11, 0XD6, 0X21, 0X50), 2);
        /// <summary>
        /// The sensor latitude in degrees property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_LATITUDE_DEGREES = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 2);
        /// <summary>
        /// The sensor longitude in degrees property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_LONGITUDE_DEGREES = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 3);
        /// <summary>
        /// The sensor altitude from sea level in meters property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_ALTITUDE_SEALEVEL_METERS = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 4);
        /// <summary>
        /// The sensor altitude in meters property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_ALTITUDE_ELLIPSOID_METERS = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 5);
        /// <summary>
        /// The sensor speed in knots property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_SPEED_KNOTS = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 6);
        /// <summary>
        /// The sensor true heading in degrees property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_TRUE_HEADING_DEGREES = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 7);
        /// <summary>
        /// The sensor magnetic heading in degrees property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_MAGNETIC_HEADING_DEGREES = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 8);
        /// <summary>
        /// The sensor magnetic variation property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_MAGNETIC_VARIATION = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 9);
        /// <summary>
        /// The sensor data fix quality property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_FIX_QUALITY = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 10);
        /// <summary>
        /// The sensor data fix type property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_FIX_TYPE = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 11);
        /// <summary>
        /// The sensor position dilution of precision property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_POSITION_DILUTION_OF_PRECISION = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 12);
        /// <summary>
        /// The sensor horizontal dilution of precision property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_HORIZONAL_DILUTION_OF_PRECISION = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 13);
        /// <summary>
        /// The sensor vertical dilution of precision property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_VERTICAL_DILUTION_OF_PRECISION = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 14);
        /// <summary>
        /// The sensor number of satelites used property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_SATELLITES_USED_COUNT = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 15);
        /// <summary>
        /// The sensor number of satelites used property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_SATELLITES_USED_PRNS = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 16);
        /// <summary>
        /// The sensor view property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_SATELLITES_IN_VIEW = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 17);
        /// <summary>
        /// The sensor view property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_SATELLITES_IN_VIEW_PRNS = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 18);
        /// <summary>
        /// The sensor elevation property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_SATELLITES_IN_VIEW_ELEVATION = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 19);
        /// <summary>
        /// The sensor azimuth value for satelites in view property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_SATELLITES_IN_VIEW_AZIMUTH = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 20);
        /// <summary>
        /// The sensor signal to noise ratio for satelites in view property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_SATELLITES_IN_VIEW_STN_RATIO = PROPERTYKEY.Create(new Guid(0X055C74D8, 0XCA6F, 0X47D6, 0X95, 0XC6, 0X1E, 0XD3, 0X63, 0X7A, 0X0F, 0XF4), 21);
        /// <summary>
        /// The sensor temperature in celsius property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_TEMPERATURE_CELSIUS = PROPERTYKEY.Create(new Guid(0X8B0AA2F1, 0X2D57, 0X42EE, 0X8C, 0XC0, 0X4D, 0X27, 0X62, 0X2B, 0X46, 0XC4), 2);
        /// <summary>
        /// The sensor gravitational acceleration (X-axis) property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_ACCELERATION_X_G = PROPERTYKEY.Create(new Guid(0X3F8A69A2, 0X7C5, 0X4E48, 0XA9, 0X65, 0XCD, 0X79, 0X7A, 0XAB, 0X56, 0XD5), 2);
        /// <summary>
        /// The sensor gravitational acceleration (Y-axis) property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_ACCELERATION_Y_G = PROPERTYKEY.Create(new Guid(0X3F8A69A2, 0X7C5, 0X4E48, 0XA9, 0X65, 0XCD, 0X79, 0X7A, 0XAB, 0X56, 0XD5), 3);
        /// <summary>
        /// The sensor gravitational acceleration (Z-axis) property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_ACCELERATION_Z_G = PROPERTYKEY.Create(new Guid(0X3F8A69A2, 0X7C5, 0X4E48, 0XA9, 0X65, 0XCD, 0X79, 0X7A, 0XAB, 0X56, 0XD5), 4);
        /// <summary>
        /// The sensor angular acceleration per second (X-axis) property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_ANGULAR_ACCELERATION_X_DEGREES_PER_SECOND = PROPERTYKEY.Create(new Guid(0X3F8A69A2, 0X7C5, 0X4E48, 0XA9, 0X65, 0XCD, 0X79, 0X7A, 0XAB, 0X56, 0XD5), 5);
        /// <summary>
        /// The sensor angular acceleration per second (Y-axis) property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_ANGULAR_ACCELERATION_Y_DEGREES_PER_SECOND = PROPERTYKEY.Create(new Guid(0X3F8A69A2, 0X7C5, 0X4E48, 0XA9, 0X65, 0XCD, 0X79, 0X7A, 0XAB, 0X56, 0XD5), 6);
        /// <summary>
        /// The sensor angular acceleration per second (Z-axis) property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_ANGULAR_ACCELERATION_Z_DEGREES_PER_SECOND = PROPERTYKEY.Create(new Guid(0X3F8A69A2, 0X7C5, 0X4E48, 0XA9, 0X65, 0XCD, 0X79, 0X7A, 0XAB, 0X56, 0XD5), 7);
        /// <summary>
        /// The sensor angle in degrees (X-axis) property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_ANGLE_X_DEGREES = PROPERTYKEY.Create(new Guid(0XC2FB0F5F, 0XE2D2, 0X4C78, 0XBC, 0XD0, 0X35, 0X2A, 0X95, 0X82, 0X81, 0X9D), 2);
        /// <summary>
        /// The sensor angle in degrees (Y-axis) property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_ANGLE_Y_DEGREES = PROPERTYKEY.Create(new Guid(0XC2FB0F5F, 0XE2D2, 0X4C78, 0XBC, 0XD0, 0X35, 0X2A, 0X95, 0X82, 0X81, 0X9D), 3);
        /// <summary>
        /// The sensor angle in degrees (Z-axis) property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_ANGLE_Z_DEGREES = PROPERTYKEY.Create(new Guid(0XC2FB0F5F, 0XE2D2, 0X4C78, 0XBC, 0XD0, 0X35, 0X2A, 0X95, 0X82, 0X81, 0X9D), 4);
        /// <summary>
        /// The sensor magnetic heading (X-axis) property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_MAGNETIC_HEADING_X_DEGREES = PROPERTYKEY.Create(new Guid(0XC2FB0F5F, 0XE2D2, 0X4C78, 0XBC, 0XD0, 0X35, 0X2A, 0X95, 0X82, 0X81, 0X9D), 5);
        /// <summary>
        /// The sensor magnetic heading (Y-axis) property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_MAGNETIC_HEADING_Y_DEGREES = PROPERTYKEY.Create(new Guid(0XC2FB0F5F, 0XE2D2, 0X4C78, 0XBC, 0XD0, 0X35, 0X2A, 0X95, 0X82, 0X81, 0X9D), 6);
        /// <summary>
        /// The sensor magnetic heading (Z-axis) property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_MAGNETIC_HEADING_Z_DEGREES = PROPERTYKEY.Create(new Guid(0XC2FB0F5F, 0XE2D2, 0X4C78, 0XBC, 0XD0, 0X35, 0X2A, 0X95, 0X82, 0X81, 0X9D), 7);
        /// <summary>
        /// The sensor distance (X-axis) data property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_DISTANCE_X_METERS = PROPERTYKEY.Create(new Guid(0XC2FB0F5F, 0XE2D2, 0X4C78, 0XBC, 0XD0, 0X35, 0X2A, 0X95, 0X82, 0X81, 0X9D), 8);
        /// <summary>
        /// The sensor distance (Y-axis) data property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_DISTANCE_Y_METERS = PROPERTYKEY.Create(new Guid(0XC2FB0F5F, 0XE2D2, 0X4C78, 0XBC, 0XD0, 0X35, 0X2A, 0X95, 0X82, 0X81, 0X9D), 9);
        /// <summary>
        /// The sensor distance (Z-axis) data property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_DISTANCE_Z_METERS = PROPERTYKEY.Create(new Guid(0XC2FB0F5F, 0XE2D2, 0X4C78, 0XBC, 0XD0, 0X35, 0X2A, 0X95, 0X82, 0X81, 0X9D), 10);
        /// <summary>
        /// The sensor boolean switch data property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_BOOLEAN_SWITCH_STATE = PROPERTYKEY.Create(new Guid(0X38564A7C, 0XF2F2, 0X49BB, 0X9B, 0X2B, 0XBA, 0X60, 0XF6, 0X6A, 0X58, 0XDF), 2);
        /// <summary>
        /// The sensor multi-value switch data property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_MULTIVALUE_SWITCH_STATE = PROPERTYKEY.Create(new Guid(0X38564A7C, 0XF2F2, 0X49BB, 0X9B, 0X2B, 0XBA, 0X60, 0XF6, 0X6A, 0X58, 0XDF), 3);
        /// <summary>
        /// The sensor force (in newtons) data property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_FORCE_NEWTONS = PROPERTYKEY.Create(new Guid(0X38564A7C, 0XF2F2, 0X49BB, 0X9B, 0X2B, 0XBA, 0X60, 0XF6, 0X6A, 0X58, 0XDF), 4);
        /// <summary>
        /// The sensor weight (in kilograms) data property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_WEIGHT_KILOGRAMS = PROPERTYKEY.Create(new Guid(0X38564A7C, 0XF2F2, 0X49BB, 0X9B, 0X2B, 0XBA, 0X60, 0XF6, 0X6A, 0X58, 0XDF), 5);
        /// <summary>
        /// The sensor pressure data property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_PRESSURE_PASCAL = PROPERTYKEY.Create(new Guid(0X38564A7C, 0XF2F2, 0X49BB, 0X9B, 0X2B, 0XBA, 0X60, 0XF6, 0X6A, 0X58, 0XDF), 6);
        /// <summary>
        /// The sensor strain data property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_STRAIN = PROPERTYKEY.Create(new Guid(0X38564A7C, 0XF2F2, 0X49BB, 0X9B, 0X2B, 0XBA, 0X60, 0XF6, 0X6A, 0X58, 0XDF), 7);
        /// <summary>
        /// The sensor human presence data property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_HUMAN_PRESENCE = PROPERTYKEY.Create(new Guid(0X2299288A, 0X6D9E, 0X4B0B, 0XB7, 0XEC, 0X35, 0X28, 0XF8, 0X9E, 0X40, 0XAF), 2);
        /// <summary>
        /// The sensor human proximity data property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_HUMAN_PROXIMITY = PROPERTYKEY.Create(new Guid(0X2299288A, 0X6D9E, 0X4B0B, 0XB7, 0XEC, 0X35, 0X28, 0XF8, 0X9E, 0X40, 0XAF), 3);
        /// <summary>
        /// The sensor light data property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_LIGHT_LUX = PROPERTYKEY.Create(new Guid(0XE4C77CE2, 0XDCB7, 0X46E9, 0X84, 0X39, 0X4F, 0XEC, 0X54, 0X88, 0X33, 0XA6), 2);
        /// <summary>
        /// The sensor 40-bit RFID tag data property key.
        /// </summary>
        public static readonly PROPERTYKEY SENSOR_DATA_TYPE_RFID_TAG_40_BIT = PROPERTYKEY.Create(new Guid(0XD7A59A3C, 0X3421, 0X44AB, 0X8D, 0X3A, 0X9D, 0XE8, 0XAB, 0X6C, 0X4C, 0XAE), 2);
    }

    /// <summary>
    /// Contains a list of well known sensor categories.
    /// </summary>
    public sealed class SensorCategories
    {
        /// <summary>
        /// The sensor category for all categories.
        /// </summary>
        public static readonly Guid All = new Guid(0xC317C286, 0xC468, 0x4288, 0x99, 0x75, 0xD4, 0xC4, 0x58, 0x7C, 0x44, 0x2C);
        /// <summary>
        /// The sensor location category property key.
        /// </summary>
        public static readonly Guid Location = new Guid(0xBFA794E4, 0xF964, 0x4FDB, 0x90, 0xF6, 0x51, 0x5, 0x6B, 0xFE, 0x4B, 0x44);
        /// <summary>
        /// The environmental sensor cagetory property key.
        /// </summary>
        public static readonly Guid Environmental = new Guid(0x323439AA, 0x7F66, 0x492B, 0xBA, 0xC, 0x73, 0xE9, 0xAA, 0xA, 0x65, 0xD5);
        /// <summary>
        /// The motion sensor cagetory property key.
        /// </summary>
        public static readonly Guid Motion = new Guid(0xCD09DAF1, 0x3B2E, 0x4C3D, 0xB5, 0x98, 0xB5, 0xE5, 0xFF, 0x93, 0xFD, 0x46);
        /// <summary>
        /// The orientation sensor cagetory property key.
        /// </summary>
        public static readonly Guid Orientation = new Guid(0x9E6C04B6, 0x96FE, 0x4954, 0xB7, 0x26, 0x68, 0x68, 0x2A, 0x47, 0x3F, 0x69);
        /// <summary>
        /// The mechanical sensor cagetory property key.
        /// </summary>
        public static readonly Guid Mechanical = new Guid(0x8D131D68, 0x8EF7, 0x4656, 0x80, 0xB5, 0xCC, 0xCB, 0xD9, 0x37, 0x91, 0xC5);
        /// <summary>
        /// The electrical sensor cagetory property key.
        /// </summary>
        public static readonly Guid Electrical = new Guid(0xFB73FCD8, 0xFC4A, 0x483C, 0xAC, 0x58, 0x27, 0xB6, 0x91, 0xC6, 0xBE, 0xFF);
        /// <summary>
        /// The bio-metric sensor cagetory property key.
        /// </summary>
        public static readonly Guid BioMetric = new Guid(0xCA19690F, 0xA2C7, 0x477D, 0xA9, 0x9E, 0x99, 0xEC, 0x6E, 0x2B, 0x56, 0x48);
        /// <summary>
        /// The light sensor cagetory property key.
        /// </summary>
        public static readonly Guid Light = new Guid(0x17A665C0, 0x9063, 0x4216, 0xB2, 0x02, 0x5C, 0x7A, 0x25, 0x5E, 0x18, 0xCE);
        /// <summary>
        /// The scanner sensor cagetory property key.
        /// </summary>
        public static readonly Guid Scanner = new Guid(0xB000E77E, 0xF5B5, 0x420F, 0x81, 0x5D, 0x2, 0x70, 0xA7, 0x26, 0xF2, 0x70);
    }

    /// <summary>
    /// Contains a list of well known sensor types.
    /// </summary>
    public sealed class SensorTypes
    {
        /// <summary>
        /// The GPS location sensor type property key.
        /// </summary>
        public static readonly Guid LocationGps = new Guid(0xED4CA589, 0x327A, 0x4FF9, 0xA5, 0x60, 0x91, 0xDA, 0x4B, 0x48, 0x27, 0x5E);
        /// <summary>
        /// The environmental temperature sensor type property key.
        /// </summary>
        public static readonly Guid EnvironmentalTemperature = new Guid(0x04FD0EC4, 0xD5DA, 0x45FA, 0x95, 0xA9, 0x5D, 0xB3, 0x8E, 0xE1, 0x93, 0x06);
        /// <summary>
        /// The environmental atmostpheric pressure sensor type property key.
        /// </summary>
        public static readonly Guid EnvironmentalAtmosphericPressure = new Guid(0xE903829, 0xFF8A, 0x4A93, 0x97, 0xDF, 0x3D, 0xCB, 0xDE, 0x40, 0x22, 0x88);
        /// <summary>
        /// The environmental humidity sensor type property key.
        /// </summary>
        public static readonly Guid EnvironmentalHumidity = new Guid(0x5C72BF67, 0xBD7E, 0x4257, 0x99, 0xB, 0x98, 0xA3, 0xBA, 0x3B, 0x40, 0xA);
        /// <summary>
        /// The environmental wind speed sensor type property key.
        /// </summary>
        public static readonly Guid EnvironmentalWindSpeed = new Guid(0xDD50607B, 0xA45F, 0x42CD, 0x8E, 0xFD, 0xEC, 0x61, 0x76, 0x1C, 0x42, 0x26);
        /// <summary>
        /// The environmental wind direction sensor type property key.
        /// </summary>
        public static readonly Guid EnvironmentalWindDirection = new Guid(0x9EF57A35, 0x9306, 0x434D, 0xAF, 0x9, 0x37, 0xFA, 0x5A, 0x9C, 0x0, 0xBD);
        /// <summary>
        /// The accelerometer sensor type property key.
        /// </summary>
        public static readonly Guid Accelerometer1d = new Guid(0xC04D2387, 0x7340, 0x4CC2, 0x99, 0x1E, 0x3B, 0x18, 0xCB, 0x8E, 0xF2, 0xF4);
        /// <summary>
        /// The 2d accelerometer sensor type property key.
        /// </summary>
        public static readonly Guid Accelerometer2d = new Guid(0xB2C517A8, 0xF6B5, 0x4BA6, 0xA4, 0x23, 0x5D, 0xF5, 0x60, 0xB4, 0xCC, 0x7);
        /// <summary>
        /// The 3d accelerometer sensor type property key.
        /// </summary>
        public static readonly Guid Accelerometer3d = new Guid(0xC2FB0F5F, 0xE2D2, 0x4C78, 0xBC, 0xD0, 0x35, 0x2A, 0x95, 0x82, 0x81, 0x9D);
        /// <summary>
        /// The motion sensor type property key.
        /// </summary>
        public static readonly Guid MotionDetector = new Guid(0x5C7C1A12, 0x30A5, 0x43B9, 0xA4, 0xB2, 0xCF, 0x9, 0xEC, 0x5B, 0x7B, 0xE8);
        /// <summary>
        /// The gyrometer sensor type property key.
        /// </summary>
        public static readonly Guid Gyrometer1d = new Guid(0xFA088734, 0xF552, 0x4584, 0x83, 0x24, 0xED, 0xFA, 0xF6, 0x49, 0x65, 0x2C);
        /// <summary>
        /// The 2d gyrometer sensor type property key.
        /// </summary>
        public static readonly Guid Gyrometer2d = new Guid(0x31EF4F83, 0x919B, 0x48BF, 0x8D, 0xE0, 0x5D, 0x7A, 0x9D, 0x24, 0x5, 0x56);
        /// <summary>
        /// The 3d gyrometer sensor type property key.
        /// </summary>
        public static readonly Guid Gyrometer3d = new Guid(0x9485F5A, 0x759E, 0x42C2, 0xBD, 0x4B, 0xA3, 0x49, 0xB7, 0x5C, 0x86, 0x43);
        /// <summary>
        /// The speedometer sensor type property key.
        /// </summary>
        public static readonly Guid Speedometer = new Guid(0x6BD73C1F, 0xBB4, 0x4310, 0x81, 0xB2, 0xDF, 0xC1, 0x8A, 0x52, 0xBF, 0x94);
        /// <summary>
        /// The compass sensor type property key.
        /// </summary>
        public static readonly Guid Compass1d = new Guid(0xA415F6C5, 0xCB50, 0x49D0, 0x8E, 0x62, 0xA8, 0x27, 0xB, 0xD7, 0xA2, 0x6C);
        /// <summary>
        /// The 2d compass sensor type property key.
        /// </summary>
        public static readonly Guid Compass2d = new Guid(0x15655CC0, 0x997A, 0x4D30, 0x84, 0xDB, 0x57, 0xCA, 0xBA, 0x36, 0x48, 0xBB);
        /// <summary>
        /// The 3d compass sensor type property key.
        /// </summary>
        public static readonly Guid Compass3d = new Guid(0x76B5CE0D, 0x17DD, 0x414D, 0x93, 0xA1, 0xE1, 0x27, 0xF4, 0xB, 0xDF, 0x6E);
        /// <summary>
        /// The inclinometer sensor type property key.
        /// </summary>
        public static readonly Guid Inclinometer1d = new Guid(0xB96F98C5, 0x7A75, 0x4BA7, 0x94, 0xE9, 0xAC, 0x86, 0x8C, 0x96, 0x6D, 0xD8);
        /// <summary>
        /// The 2D inclinometer sensor type property key.
        /// </summary>
        public static readonly Guid Inclinometer2d = new Guid(0xAB140F6D, 0x83EB, 0x4264, 0xB7, 0xB, 0xB1, 0x6A, 0x5B, 0x25, 0x6A, 0x1);
        /// <summary>
        /// The 3D inclinometer sensor type property key.
        /// </summary>
        public static readonly Guid Inclinometer3d = new Guid(0xB84919FB, 0xEA85, 0x4976, 0x84, 0x44, 0x6F, 0x6F, 0x5C, 0x6D, 0x31, 0xDB);
        /// <summary>
        /// The distance sensor type property key.
        /// </summary>
        public static readonly Guid Distance1d = new Guid(0x5F14AB2F, 0x1407, 0x4306, 0xA9, 0x3F, 0xB1, 0xDB, 0xAB, 0xE4, 0xF9, 0xC0);
        /// <summary>
        /// The 2D sensor type property key.
        /// </summary>
        public static readonly Guid Distance2d = new Guid(0x5CF9A46C, 0xA9A2, 0x4E55, 0xB6, 0xA1, 0xA0, 0x4A, 0xAF, 0xA9, 0x5A, 0x92);
        /// <summary>
        /// The 3D distance sensor type property key.
        /// </summary>
        public static readonly Guid Distance3d = new Guid(0xA20CAE31, 0xE25, 0x4772, 0x9F, 0xE5, 0x96, 0x60, 0x8A, 0x13, 0x54, 0xB2);
        /// <summary>
        /// The electrical voltage sensor type property key.
        /// </summary>
        public static readonly Guid Voltage = new Guid(0xC5484637, 0x4FB7, 0x4953, 0x98, 0xB8, 0xA5, 0x6D, 0x8A, 0xA1, 0xFB, 0x1E);
        /// <summary>
        /// The electrical current sensor type property key.
        /// </summary>
        public static readonly Guid Current = new Guid(0x5ADC9FCE, 0x15A0, 0x4BBE, 0xA1, 0xAD, 0x2D, 0x38, 0xA9, 0xAE, 0x83, 0x1C);
        /// <summary>
        /// The boolean switch sensor type property key.
        /// </summary>
        public static readonly Guid BooleanSwitch = new Guid(0x9C7E371F, 0x1041, 0x460B, 0x8D, 0x5C, 0x71, 0xE4, 0x75, 0x2E, 0x35, 0xC);
        /// <summary>
        /// The multiple value switch sensor type property key.
        /// </summary>
        public static readonly Guid MultiValueSwitch = new Guid(0xB3EE4D76, 0x37A4, 0x4402, 0xB2, 0x5E, 0x99, 0xC6, 0xA, 0x77, 0x5F, 0xA1);
        /// <summary>
        /// The force sensor type property key.
        /// </summary>
        public static readonly Guid Force = new Guid(0xC2AB2B02, 0x1A1C, 0x4778, 0xA8, 0x1B, 0x95, 0x4A, 0x17, 0x88, 0xCC, 0x75);
        /// <summary>
        /// The scale sensor type property key.
        /// </summary>
        public static readonly Guid Scale = new Guid(0xC06DD92C, 0x7FEB, 0x438E, 0x9B, 0xF6, 0x82, 0x20, 0x7F, 0xFF, 0x5B, 0xB8);
        /// <summary>
        /// The pressure sensor type property key.
        /// </summary>
        public static readonly Guid Pressure = new Guid(0x26D31F34, 0x6352, 0x41CF, 0xB7, 0x93, 0xEA, 0x7, 0x13, 0xD5, 0x3D, 0x77);
        /// <summary>
        /// The strain sensor type property key.
        /// </summary>
        public static readonly Guid Strain = new Guid(0xC6D1EC0E, 0x6803, 0x4361, 0xAD, 0x3D, 0x85, 0xBC, 0xC5, 0x8C, 0x6D, 0x29);
        /// <summary>
        /// The Human presence sensor type property key.
        /// </summary>
        public static readonly Guid HumanPresence = new Guid(0xC138C12B, 0xAD52, 0x451C, 0x93, 0x75, 0x87, 0xF5, 0x18, 0xFF, 0x10, 0xC6);
        /// <summary>
        /// The human proximity sensor type property key.
        /// </summary>
        public static readonly Guid HumanProximity = new Guid(0x5220DAE9, 0x3179, 0x4430, 0x9F, 0x90, 0x6, 0x26, 0x6D, 0x2A, 0x34, 0xDE);
        /// <summary>
        /// The touch sensor type property key.
        /// </summary>
        public static readonly Guid Touch = new Guid(0x17DB3018, 0x6C4, 0x4F7D, 0x81, 0xAF, 0x92, 0x74, 0xB7, 0x59, 0x9C, 0x27);
        /// <summary>
        /// The ambient light sensor type property key.
        /// </summary>
        public static Guid AmbientLight = new Guid(0x97F115C8, 0x599A, 0x4153, 0x88, 0x94, 0xD2, 0xD1, 0x28, 0x99, 0x91, 0x8A);
        /// <summary>
        /// The RFID sensor type property key.
        /// </summary>
        public static readonly Guid RFIDScanner = new Guid(0x44328EF5, 0x2DD, 0x4E8D, 0xAD, 0x5D, 0x92, 0x49, 0x83, 0x2B, 0x2E, 0xCA);
        /// <summary>
        /// The bar code scanner sensor type property key.
        /// </summary>
        public static readonly Guid BarcodeScanner = new Guid(0x990B3D8F, 0x85BB, 0x45FF, 0x91, 0x4D, 0x99, 0x8C, 0x4, 0xF3, 0x72, 0xDF);
    }
}
