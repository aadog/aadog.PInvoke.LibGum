using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace aadog.PInvoke.LibGum;


[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumReturnAddressArray
{
    public guint len;
    public List<IntPtr> items;
}