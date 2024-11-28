using System;
using System.Runtime.InteropServices;
using aadog.PInvoke.LibGum.Enums;

namespace aadog.PInvoke.LibGum;
[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumThreadDetails
{
    public GumThreadId id;
    public IntPtr name;
    public GumThreadState state;
    public GumCpuContext cpu_context;
};