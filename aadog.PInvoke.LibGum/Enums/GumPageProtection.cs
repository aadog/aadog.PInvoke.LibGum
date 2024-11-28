namespace aadog.PInvoke.LibGum.Enums;

public enum GumPageProtection
{
    GUM_PAGE_NO_ACCESS = 0,
    GUM_PAGE_READ = (1 << 0),
    GUM_PAGE_WRITE = (1 << 1),
    GUM_PAGE_EXECUTE = (1 << 2),
    GUM_PAGE_RW=GUM_PAGE_READ | GUM_PAGE_WRITE,
    GUM_PAGE_RX=GUM_PAGE_READ | GUM_PAGE_EXECUTE,
    GUM_PAGE_RWX=GUM_PAGE_READ | GUM_PAGE_WRITE | GUM_PAGE_EXECUTE
};