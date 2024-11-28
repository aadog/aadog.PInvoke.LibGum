using System;
using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumSectionDetails
{
    public IntPtr id;
    public IntPtr name;
    public IntPtr address;
    public gsize size;
};