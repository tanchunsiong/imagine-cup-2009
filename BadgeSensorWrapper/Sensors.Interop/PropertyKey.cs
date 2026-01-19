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
using System.Diagnostics;

namespace Interop.Sensors
{
    /// <summary>
    /// Specifies the FMTID/PID identifier that programmatically identifies a property.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 0x4)]
    public struct PROPERTYKEY
    {
        /// <summary>
        /// A unique GUID for the property.
        /// </summary>
        public Guid fmtid;
        /// <summary>
        /// A property identifier (PID). Any value greater than or equal to 2 is acceptable.
        /// </summary>
        public Int32 pid;

        /// <summary>
        /// Create a new property key from the FMTID and PID identifiers.
        /// </summary>
        public static PROPERTYKEY Create(Guid guid, int id)
        {
            PROPERTYKEY key = new PROPERTYKEY();
            key.fmtid = guid;
            key.pid = id;

            return key;
        }
        public static PROPERTYKEY Create(string guid, int id)
        {
            PROPERTYKEY key = new PROPERTYKEY();
            key.fmtid = new Guid( guid );
            key.pid = id;

            return key;
        }
    }
}
