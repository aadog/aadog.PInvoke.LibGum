using aadog.PInvoke.LibGum;
using System;
using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumObject
{
    // public GTypeInstance  g_type_instance;
    // public IntPtr ref_count;
    // public unsafe delegate* unmanaged<GumObject*, void> finalize;
}