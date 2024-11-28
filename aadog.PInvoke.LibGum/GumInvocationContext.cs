using System;
using System.Runtime.InteropServices;

namespace aadog.PInvoke.LibGum;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GumInvocationContext
{
    public IntPtr getArg(uint n)
    {
        IntPtr result;
        fixed(GumInvocationContext* p=&this)
            result= LibGumFunctions.gum_invocation_context_get_nth_argument(p, n);
        return result;
    }
    public IntPtr getReturnAddress(uint n)
    {
        IntPtr result;
        fixed (GumInvocationContext* p = &this)
            result = LibGumFunctions.gum_invocation_context_get_return_address(p);
        return result;
    }
    public IntPtr getReturnValue(uint n)
    {
        IntPtr result;
        fixed (GumInvocationContext* p = &this)
            result = LibGumFunctions.gum_invocation_context_get_return_value(p);
        return result;
    }
    public GumThreadId getThreadId(uint n)
    {
        GumThreadId result;
        fixed (GumInvocationContext* p = &this)
            result = LibGumFunctions.gum_invocation_context_get_thread_id(p);
        return result;
    }
    public void ReplaceArg(uint n, IntPtr v)
    {
        fixed (GumInvocationContext* p = &this)
            LibGumFunctions.gum_invocation_context_replace_nth_argument(p, n, v);
    }
    public void ReplaceReturnValue(IntPtr v)
    {
        fixed (GumInvocationContext* p = &this)
            LibGumFunctions.gum_invocation_context_replace_return_value(p, v);
    }

    public IntPtr GetListenerFunctionData()
    {
        IntPtr result;
        fixed (GumInvocationContext* p = &this)
        {
            result= LibGumFunctions.gum_invocation_context_get_listener_function_data(p);
        }
        return result;
    }
    public IntPtr GetListenerInvocationData(gsize size)
    {
        IntPtr result;
        fixed (GumInvocationContext* p = &this)
        {
            result = LibGumFunctions.gum_invocation_context_get_listener_invocation_data(p, size);
        }
        return result;
    }
    public IntPtr GetListenerThreadData()
    {
        IntPtr result;
        fixed (GumInvocationContext* p = &this)
        {
            result = LibGumFunctions.gum_invocation_context_get_listener_thread_data(p, 8);
        }
        return result;
    }
}