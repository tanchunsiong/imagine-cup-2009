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
using HRESULT = System.Int32;

namespace Interop.Sensors
{
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CAE02BBF-798B-4508-A207-35A7906DC73D")]
    public interface ILocationEvents
    {
        [PreserveSig]
        HRESULT OnLocationChanged([In] ref Guid reportType, [In] ILocationReport pLocationReport);

        [PreserveSig]
        HRESULT OnStatusChanged([In] ref Guid reportType, [In] ReportStatus newStatus);
    }
}
