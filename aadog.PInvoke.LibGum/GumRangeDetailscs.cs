using System.Runtime.InteropServices;
using aadog.PInvoke.LibGum.Enums;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumRangeDetails
{
    public GumMemoryRange* range;
    public GumPageProtection protection;
    public GumFileMapping* file;
};