using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum;
[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumDebugSymbolDetails
{
    public IntPtr address;
    public byte[] module_name;
    public byte[] symbol_name;
    public byte[] file_name;
    public guint line_number;
    public guint column;
}