using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace aadog.PInvoke.LibGum
{

    //这里应该使用MarshalMode.ManagedToUnmanagedRef 封装，不过好像有bug，只能手动实现
    // [CustomMarshaller(typeof(GumReturnAddressArray), MarshalMode.ManagedToUnmanagedIn, typeof(ManagedToUnmanagedIn))]

    // public static unsafe class GumReturnAddressArrayMarshaller
    // {
    //     static void Log(string msg)
    //     {
    //         string tag = "dot";
    //         LibLog.LOG_DEBUG(tag, msg);
    //     }
    //     public unsafe struct ManagedToUnmanagedIn
    //     {
    //         private void* _money;
    //         public void FromManaged(GumReturnAddressArray handle)
    //         {
    //    
    //         }
    //
    //         public void* ToUnmanaged()
    //         {
    //             _money= NativeMemory.AllocZeroed(10000);
    //             return _money;
    //         }
    //
    //         public void Free()
    //         {
    //             NativeMemory.Free(_money);
    //         }
    //     }
    // }
}
