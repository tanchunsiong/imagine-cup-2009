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
using System.Security.Permissions;
using System.Globalization;
using VARTYPE = System.UInt16;
using WORD = System.UInt16;

namespace Interop.Sensors
{
    [StructLayout(LayoutKind.Explicit)]
    public sealed class PROPVARIANT
    {
        [FieldOffset(0)]
        private VarEnum vt;

        [FieldOffset(8)]
        private SByte cVal;
        [FieldOffset(8)]
        private Byte bVal;
        [FieldOffset(8)]
        private UInt16 iVal;
        [FieldOffset(8)]
        private UInt16 uiVal;
        [FieldOffset(8)]
        private Int32 lVal;
        [FieldOffset(8)]
        private UInt32 ulVal;
        [FieldOffset(8)]
        private Int32 intVal;
        [FieldOffset(8)]
        private UInt32 uintVal;
        [FieldOffset(8)]
        private Int64 hVal;
        [FieldOffset(8)]
        private UInt64 uhVal;
        [FieldOffset(8)]
        private Single fltVal;
        [FieldOffset(8)]
        private Double dblVal;
        [FieldOffset(8)]
        private DateTime date;
        [FieldOffset(8), MarshalAs(UnmanagedType.VariantBool)]
        private Boolean boolVal;
        [FieldOffset(8), MarshalAs(UnmanagedType.Error)]
        private Int32 scode;
        [FieldOffset(8)]
        private System.Runtime.InteropServices.ComTypes.FILETIME filetime;
        [FieldOffset(8)]
        private IntPtr ptr;

        public VarEnum VarType
        {
            get { return vt; }
        }

        public object Value
        {
            get { return GetValue(VarType); }
        }

        private object GetValue(VarEnum vt)
        {
            object value = null;

            switch ((VarEnum)vt)
            {
                case VarEnum.VT_EMPTY:
                case VarEnum.VT_NULL:
                    value = null;
                    break;

                case VarEnum.VT_I1:
                    value = cVal;
                    break;

                case VarEnum.VT_UI1:
                    value = bVal;
                    break;

                case VarEnum.VT_I2:
                    value = iVal;
                    break;

                case VarEnum.VT_UI2:
                    value = uiVal;
                    break;

                case VarEnum.VT_I4:
                    value = lVal;
                    break;

                case VarEnum.VT_UI4:
                    value = ulVal;
                    break;

                case VarEnum.VT_I8:
                    value = hVal;
                    break;

                case VarEnum.VT_UI8:
                    value = uhVal;
                    break;

                case VarEnum.VT_R4:
                    value = fltVal;
                    break;

                case VarEnum.VT_R8:
                    value = dblVal;
                    break;

                case VarEnum.VT_INT:
                    value = intVal;
                    break;

                case VarEnum.VT_UINT:
                    value = uintVal;
                    break;

                case VarEnum.VT_ERROR:
                    value = scode;
                    break;

                case VarEnum.VT_BOOL:
                    value = boolVal;
                    break;

                case VarEnum.VT_CY:
                    value = decimal.FromOACurrency(hVal);
                    break;

                case VarEnum.VT_DATE:
                    value = DateTime.FromOADate(dblVal);
                    break;

                case VarEnum.VT_FILETIME:
                    value = DateTime.FromFileTime(hVal);
                    break;

                case VarEnum.VT_BSTR:
                    value = Marshal.PtrToStringBSTR(ptr);
                    break;

                case VarEnum.VT_LPSTR:
                    value = Marshal.PtrToStringAnsi(ptr);
                    break;

                case VarEnum.VT_LPWSTR:
                    value = Marshal.PtrToStringUni(ptr);
                    break;

                case VarEnum.VT_UNKNOWN:
                    value = Marshal.GetObjectForIUnknown(ptr);
                    break;

                case VarEnum.VT_DISPATCH:
                    value = Marshal.GetObjectForIUnknown(ptr);
                    break;

                default:
                    throw new NotSupportedException("The type of this variable is not support ('" + vt.ToString() + "')");
                    
            }

            return value;
        }

        [DllImport("ole32.dll")]
        private static extern Int32 PropVariantClear([In, Out] PROPVARIANT pvar);

        public void Clear()
        {
            PropVariantClear(this);
        }
    }
}
