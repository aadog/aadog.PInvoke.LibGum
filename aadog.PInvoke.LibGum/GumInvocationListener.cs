using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumInvocationListener
{
    public GumObject parent;
    public unsafe delegate* unmanaged<LibGum.GumInvocationCallback> on_enter;
    public unsafe delegate* unmanaged<LibGum.GumInvocationCallback> on_leave;
    public gpointer data;
    public unsafe delegate* unmanaged<void> data_destroy;
}