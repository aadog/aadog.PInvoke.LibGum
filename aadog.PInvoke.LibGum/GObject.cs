using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GObject
{
    public GTypeInstance  g_type_instance;
  
    /*< private >*/
    public guint          ref_count;  /* (atomic) */
    // GData         *qdata;
    // public delegate* unmanaged<GObject*, void> finalize { get; set; }
}