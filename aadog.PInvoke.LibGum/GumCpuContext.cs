using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumCpuContext
{
    public guint64 pc;
    public guint64 sp;
    public guint64 nzcv;

    public guint64 x;
    public guint64 fp;
    public guint64 lr;

    // GumArm64VectorReg v[32];
}