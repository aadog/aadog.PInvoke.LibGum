using System;
using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum.Enums;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumExceptionMemoryDetails
{
    public GumMemoryOperation operation;
    public IntPtr address;
}