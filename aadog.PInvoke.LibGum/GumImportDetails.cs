using System;
using System.Runtime.InteropServices;
using aadog.PInvoke.LibGum.Enums;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumImportDetails
{
    public GumImportType type;
    public IntPtr name;
    public IntPtr module;
    public IntPtr address;
    public IntPtr slot;
};