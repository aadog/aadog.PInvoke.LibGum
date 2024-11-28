using System;
using System.Runtime.InteropServices;
using aadog.PInvoke.LibGum.Enums;

namespace aadog.PInvoke.LibGum;
[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumExportDetails
{
    public GumExportType type;
    public IntPtr name;
    public IntPtr address;
};