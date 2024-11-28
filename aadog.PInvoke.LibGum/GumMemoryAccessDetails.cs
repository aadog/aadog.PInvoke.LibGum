using System.Runtime.InteropServices;
using aadog.PInvoke.LibGum.Enums;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumMemoryAccessDetails
{
    public GumMemoryOperation operation;
    public IntPtr from;
    public IntPtr address;

    public guint range_index;
    public guint page_index;
    public guint pages_completed;
    public guint pages_total;
}