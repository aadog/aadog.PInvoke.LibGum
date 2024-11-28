using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumMallocRangeDetails
{
    public GumMemoryRange* range;
};
