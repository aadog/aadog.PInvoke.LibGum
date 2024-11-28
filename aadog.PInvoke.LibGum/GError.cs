using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GError
{
    public GQuark domain;
    public gint code;
    public gchar* message;
};
