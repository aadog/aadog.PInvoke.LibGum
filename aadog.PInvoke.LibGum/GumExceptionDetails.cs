using System;
using System.Runtime.InteropServices;
using aadog.PInvoke.LibGum.Enums;
namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumExceptionDetails
{
    public GumThreadId thread_id;
    public GumExceptionType type;
    public IntPtr address;
    public GumExceptionMemoryDetails memory;
    public GumCpuContext context;
    public IntPtr native_context;
}