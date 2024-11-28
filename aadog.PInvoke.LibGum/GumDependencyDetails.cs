using System;
using System.Runtime.InteropServices;
using aadog.PInvoke.LibGum.Enums;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumDependencyDetails
{
    public IntPtr name;
    public GumDependencyType type;
};