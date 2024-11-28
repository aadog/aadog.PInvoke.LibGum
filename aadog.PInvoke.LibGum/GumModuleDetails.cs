using System;
using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumModuleDetails
{
    public IntPtr name;
    public GumMemoryRange* range;
    public IntPtr path;
}
