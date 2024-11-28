using System;
using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumMemoryRange
{
    public IntPtr base_address;
    public gsize size;
}