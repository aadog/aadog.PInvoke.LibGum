namespace aadog.PInvoke.LibGum;

public unsafe struct GumReturnAddressDetails
{
    public GumReturnAddress address;
    public gchar[] module_name;
    public gchar[] function_name;
    public gchar[] file_name;
    public guint line_number;
    public guint column;
}
