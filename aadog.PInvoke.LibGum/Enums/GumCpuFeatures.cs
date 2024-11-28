namespace aadog.PInvoke.LibGum.Enums;
public enum _GumCpuFeatures:int
{
    GUM_CPU_AVX2 = 1 << 0,
    GUM_CPU_CET_SS = 1 << 1,
    GUM_CPU_THUMB_INTERWORK = 1 << 2,
    GUM_CPU_VFP2 = 1 << 3,
    GUM_CPU_VFP3 = 1 << 4,
    GUM_CPU_VFPD32 = 1 << 5,
    GUM_CPU_PTRAUTH = 1 << 6,
};