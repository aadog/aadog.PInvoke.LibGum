using System;
using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum;
[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumFileMapping
{
    public IntPtr path;
    public guint64 offset;
    public gsize size;
};