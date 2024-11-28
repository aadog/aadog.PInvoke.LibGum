using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum;

public static class MarshalExt
{
    public static unsafe string? ConvertLPErrorToString(GError* error)
    {
        if (error == null)
        {
            return null;
        }
        return Marshal.PtrToStringUTF8(new IntPtr(error->message));
    }
}