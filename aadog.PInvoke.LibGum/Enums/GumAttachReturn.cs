namespace aadog.PInvoke.LibGum.Enums;

public enum GumAttachReturn
{
    GUM_ATTACH_OK = 0,
    GUM_ATTACH_WRONG_SIGNATURE = -1,
    GUM_ATTACH_ALREADY_ATTACHED = -2,
    GUM_ATTACH_POLICY_VIOLATION = -3,
    GUM_ATTACH_WRONG_TYPE = -4,
};