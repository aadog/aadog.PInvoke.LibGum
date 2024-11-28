using System.Runtime.InteropServices;
using aadog.PInvoke.LibGum.Enums;

namespace aadog.PInvoke.LibGum;
[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumSymbolDetails
{
    public gboolean is_global;
    public GumSymbolType type;
    public GumSymbolSection* section;
    public IntPtr name;
    public IntPtr address;
    public gssize size;
};
