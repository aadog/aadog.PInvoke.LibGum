using System.Runtime.InteropServices;
using aadog.PInvoke.LibGum.Enums;

namespace aadog.PInvoke.LibGum
{ 
    public partial class LibGumFunctions
    {
        public static bool IsWindows = false;
        const string DllName = "Gum";


        public unsafe delegate void GObjectFinalize(IntPtr gObject);

        public unsafe delegate void GDestroyNotify(IntPtr data);

        public unsafe delegate void GFunc(IntPtr data, IntPtr user_data);

        public unsafe delegate gboolean GumExceptionHandler(GumExceptionDetails* details, IntPtr user_data);

        public unsafe delegate gboolean GumFoundApiFunc(GumApiDetails* details, IntPtr user_data);

        public unsafe delegate void GumModifyThreadFunc(GumThreadId thread_id,
            GumCpuContext* cpu_context, IntPtr user_data);

        public unsafe delegate gboolean GumFoundThreadFunc(GumThreadDetails* details, IntPtr user_data);

        public unsafe delegate gboolean GumFoundModuleFunc(GumModuleDetails* details, IntPtr user_data);

        public unsafe delegate gboolean GumFoundImportFunc(GumImportDetails* details, IntPtr user_data);

        public unsafe delegate gboolean GumFoundExportFunc(GumExportDetails* details, IntPtr user_data);

        public unsafe delegate gboolean GumFoundSymbolFunc(GumSymbolDetails* details, IntPtr user_data);

        public unsafe delegate gboolean GumFoundRangeFunc(GumRangeDetails* details, IntPtr user_data);

        public unsafe delegate gboolean GumFoundSectionFunc(GumSectionDetails* details, IntPtr user_data);

        public unsafe delegate gboolean GumFoundDependencyFunc(GumDependencyDetails* details, IntPtr user_data);

        public unsafe delegate gboolean GumFoundMallocRangeFunc(GumMallocRangeDetails* details, IntPtr user_data);

        // public unsafe delegate gboolean GumResolveExportFunc(gchar* module_name,gchar* symbol_name, IntPtr user_data);
        public unsafe delegate void GumMemoryAccessNotify(GumMemoryAccessMonitor* monitor,
            GumMemoryAccessDetails* details, IntPtr user_data);

        public unsafe delegate void GumInvocationCallback(GumInvocationContext* context,
            IntPtr user_data);



        [LibraryImport(DllName,EntryPoint = "g_print")]
        public static partial void _g_print([MarshalAs(UnmanagedType.LPUTF8Str)] string format);
        [LibraryImport(DllName)]
        public static partial void _frida_g_print([MarshalAs(UnmanagedType.LPUTF8Str)] string format);

        public void g_print(string format)
        {
            if(isWindows)
                _g_print(format);
            else
                _frida_g_print(format);
        }


        [LibraryImport(DllName)]
        public static partial void gum_init_embedded();

        [LibraryImport(DllName)]
        public static partial void gum_deinit_embedded();

        [LibraryImport(DllName)]
        public static partial void gum_init();

        [LibraryImport(DllName)]
        public static partial void gum_shutdown();

        [LibraryImport(DllName)]
        public static partial void gum_deinit();

        /*g_error*/
        [LibraryImport(DllName, EntryPoint = "g_error_free")]
        public static unsafe partial void _g_error_free(GError* error);
        [LibraryImport(DllName)]
        public static unsafe partial void _frida_g_error_free(GError* error);
        public static unsafe void g_error_free(GError* error)
        {
            if (IsWindows)
                _g_error_free(error);
            else
                _frida_g_error_free(error);
        }

        /*g_memory*/
        [LibraryImport(DllName, EntryPoint = $"g_malloc")]
        public static unsafe partial IntPtr _g_malloc(gsize n_bytes);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr _frida_g_malloc(gsize n_bytes);
        public static unsafe IntPtr g_malloc(gsize n_bytes)
        {
            if (IsWindows)
                return _g_malloc(n_bytes);
            else
                return _frida_g_malloc(n_bytes);
        }


        [LibraryImport(DllName, EntryPoint = $"g_free")]
        public static unsafe partial void _g_free(IntPtr mem);
        [LibraryImport(DllName)]
        public static unsafe partial void _frida_g_free(IntPtr mem);
        public static unsafe void g_free(IntPtr mem)
        {
            if (IsWindows)
                _g_free(mem);
            else
                _frida_g_free(mem);
        }



        [LibraryImport(DllName, EntryPoint = $"g_get_memdup")]
        public static unsafe partial IntPtr _g_memdup(IntPtr mem, guint byte_size);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr _frida_g_memdup(IntPtr mem, guint byte_size);
        public static unsafe IntPtr g_memdup(IntPtr mem, guint byte_size)
        {
            if (IsWindows)
                return _g_memdup(mem,byte_size);
            else
                return _frida_g_memdup(mem, byte_size);
        }


        /*gum_memory*/
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_malloc(gsize size);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_calloc(gsize count, gsize size);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_realloc(IntPtr mem, gsize size);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_free(IntPtr mem);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_memset(IntPtr dst, gint c, gsize n);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_memcpy(IntPtr dst, IntPtr src, gsize n);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_memmove(IntPtr dst, IntPtr src, gsize n);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_mprotect(IntPtr address, gsize size, GumPageProtection prot);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_try_mprotect(IntPtr address, gsize size, GumPageProtection prot);


        /*g_object*/
        [LibraryImport(DllName, EntryPoint = "g_object_unref")]
        public static unsafe partial void _g_object_unref(void* data);
        [LibraryImport(DllName)]
        public static unsafe partial void _frida_g_object_unref(void* data);
        public static unsafe void g_object_unref(GError* error)
        {
            if (IsWindows)
                _g_object_unref(error);
            else
                _frida_g_object_unref(error);
        }

        [LibraryImport(DllName, EntryPoint = "g_object_ref")]
        public static unsafe partial void* _g_object_ref(void* obj);
        [LibraryImport(DllName)]
        public static unsafe partial void* _frida_g_object_ref(void* obj);
        public static unsafe void* g_object_ref(void* obj)
        {
            if (IsWindows)
                return _g_object_ref(obj);
            else
                return _frida_g_object_ref(obj);
        }




        /*g_quark*/
        [LibraryImport(DllName, EntryPoint = $"g_quark_to_string")]
        public static unsafe partial char* _g_quark_to_string(GQuark quark);
        [LibraryImport(DllName)]
        public static unsafe partial char* _frida_g_quark_to_string(GQuark quark);
        public static unsafe char* g_quark_to_string(GQuark quark)
        {
            if (IsWindows)
                return _g_quark_to_string(quark);
            else
                return _frida_g_quark_to_string(quark);
        }


        /*gum_resolver*/

        [LibraryImport(DllName)]
        public static unsafe partial GumApiResolver* gum_api_resolver_make(
            [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_api_resolver_enumerate_matches(GumApiResolver* self,
            [MarshalAs(UnmanagedType.LPUTF8Str)] string query, GumFoundApiFunc func, IntPtr user_data,
            GError** error);

        /*gum_process*/

        [LibraryImport(DllName)]
        public static partial GumOS gum_process_get_native_os();

        [LibraryImport(DllName)]
        public static unsafe partial gchar* gum_process_query_libc_name();

        [LibraryImport(DllName)]
        public static partial gboolean gum_process_is_debugger_attached();

        [LibraryImport(DllName)]
        public static partial GumProcessId gum_process_get_id();

        [LibraryImport(DllName)]
        public static partial GumThreadId gum_process_get_current_thread_id();

        [LibraryImport(DllName)]
        public static partial gboolean gum_process_has_thread(GumThreadId thread_id);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_process_modify_thread(GumThreadId thread_id,
            GumModifyThreadFunc func, IntPtr user_data, GumModifyThreadFlags flags);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_process_enumerate_threads(GumFoundThreadFunc func,
            IntPtr user_data);

        [LibraryImport(DllName)]
        public static unsafe partial GumModuleDetails* gum_process_get_main_module();

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_process_resolve_module_pointer(IntPtr ptr,
            gchar** path, GumMemoryRange* range);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_process_enumerate_modules(GumFoundModuleFunc func,
            IntPtr user_data);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_process_enumerate_ranges(GumPageProtection prot,
            GumFoundRangeFunc func, IntPtr user_data);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_process_enumerate_malloc_ranges(GumFoundMallocRangeFunc func,
            IntPtr user_data);


        /*gum_thread*/
        [LibraryImport(DllName)]
        public static unsafe partial gint gum_thread_get_system_error();

        [LibraryImport(DllName)]
        public static unsafe partial void gum_thread_set_system_error(gint value);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_thread_suspend(GumThreadId thread_id, GError** error);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_thread_resume(GumThreadId thread_id, GError** error);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_thread_set_hardware_breakpoint(GumThreadId thread_id,
            guint breakpoint_id, IntPtr address, GError** error);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_thread_unset_hardware_breakpoint(GumThreadId thread_id,
            guint breakpoint_id, GError** error);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_thread_set_hardware_watchpoint(GumThreadId thread_id,
            guint watchpoint_id, IntPtr address, gsize size, GumWatchConditions wc,
            GError** error);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_thread_unset_hardware_watchpoint(GumThreadId thread_id,
            guint watchpoint_id, GError** error);


        /*gum_module*/
        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_module_load([MarshalAs(UnmanagedType.LPUTF8Str)] string module_name,
            GError** error);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_module_ensure_initialized(
            [MarshalAs(UnmanagedType.LPUTF8Str)] string module_name);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_module_enumerate_imports(
            [MarshalAs(UnmanagedType.LPUTF8Str)] string module_name, GumFoundImportFunc func,
            IntPtr user_data);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_module_enumerate_exports(
            [MarshalAs(UnmanagedType.LPUTF8Str)] string module_name, GumFoundExportFunc func,
            IntPtr user_data);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_module_enumerate_symbols(
            [MarshalAs(UnmanagedType.LPUTF8Str)] string module_name, GumFoundSymbolFunc func,
            IntPtr user_data);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_module_enumerate_ranges(
            [MarshalAs(UnmanagedType.LPUTF8Str)] string module_name, GumPageProtection prot, GumFoundRangeFunc func,
            IntPtr user_data);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_module_enumerate_sections(
            [MarshalAs(UnmanagedType.LPUTF8Str)] string module_name, GumFoundSectionFunc prot,
            IntPtr user_data);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_module_enumerate_dependencies(
            [MarshalAs(UnmanagedType.LPUTF8Str)] string module_name, GumFoundDependencyFunc prot,
            IntPtr user_data);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_module_find_base_address(
            [MarshalAs(UnmanagedType.LPUTF8Str)] string module_name);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_module_find_export_by_name(
            [MarshalAs(UnmanagedType.LPUTF8Str)] string? module_name,
            [MarshalAs(UnmanagedType.LPUTF8Str)] string symbol_name);

        [LibraryImport(DllName,EntryPoint = "gum_module_find_export_by_name")]
        public static unsafe partial IntPtr gum_module_find_export_by_name111(
            [MarshalAs(UnmanagedType.LPUTF8Str)] string? module_name,
            [MarshalAs(UnmanagedType.LPUTF8Str)] string symbol_name);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_module_find_symbol_by_name(
            [MarshalAs(UnmanagedType.LPUTF8Str)] string? module_name,
            [MarshalAs(UnmanagedType.LPUTF8Str)] string symbol_name);

        [LibraryImport(DllName)]
        public static unsafe partial gchar* gum_symbol_type_to_string(GumSymbolType type);

        /*gum_symbol*/
        [LibraryImport(DllName)]
        public static unsafe partial gchar* gum_symbol_name_from_address(IntPtr address);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_symbol_details_from_address(IntPtr address,
            ref IntPtr details);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_return_address_details_from_address(GumReturnAddress address,
            ref IntPtr details);

        /*gum_interceptor*/
        [LibraryImport(DllName)]
        public static unsafe partial GumInterceptor* gum_interceptor_obtain();

        [LibraryImport(DllName)]
        public static unsafe partial GumAttachReturn gum_interceptor_attach(GumInterceptor* self,
            IntPtr function_address, GumInvocationListener* listener,
            IntPtr listener_function_data);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_interceptor_detach(GumInterceptor* self,
            GumInvocationListener* listener);

        [LibraryImport(DllName)]
        public static unsafe partial GumReplaceReturn gum_interceptor_replace(GumInterceptor* self,
            IntPtr function_address, IntPtr replacement_function,
            IntPtr replacement_data, ref IntPtr original_function);

        [LibraryImport(DllName)]
        public static unsafe partial GumReplaceReturn gum_interceptor_replace_fast(GumInterceptor* self,
            IntPtr function_address, IntPtr replacement_function,
            ref IntPtr original_function);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_interceptor_revert(GumInterceptor* self,
            IntPtr function_address);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_interceptor_begin_transaction(GumInterceptor* self);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_interceptor_end_transaction(GumInterceptor* self);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_interceptor_flush(GumInterceptor* self);

        [LibraryImport(DllName)]
        public static unsafe partial GumInvocationListener* gum_make_call_listener(GumInvocationCallback? on_enter,
            GumInvocationCallback? on_leave, IntPtr data, GDestroyNotify? data_destroy);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_invocation_context_get_nth_argument(
            GumInvocationContext* context, guint n);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_invocation_context_replace_nth_argument(
            GumInvocationContext* context, guint n, IntPtr value);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_invocation_context_get_return_value(
            GumInvocationContext* context);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_invocation_context_replace_return_value(
            GumInvocationContext* context, IntPtr value);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_invocation_context_get_return_address(
            GumInvocationContext* context);

        [LibraryImport(DllName)]
        public static unsafe partial guint gum_invocation_context_get_thread_id(
            GumInvocationContext* context);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_invocation_context_get_listener_function_data(
            GumInvocationContext* context);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_invocation_context_get_listener_invocation_data(
            GumInvocationContext* context, gsize required_size);

        [LibraryImport(DllName)]
        public static unsafe partial IntPtr gum_invocation_context_get_listener_thread_data(
            GumInvocationContext* context, gsize required_size);

        /*gum_backtracer*/
        [LibraryImport(DllName)]
        public static unsafe partial GumBacktracer* gum_backtracer_make_accurate();

        [LibraryImport(DllName)]
        public static unsafe partial GumBacktracer* gum_backtracer_make_fuzzy();

        [LibraryImport(DllName)]
        public static unsafe partial void gum_backtracer_generate(GumBacktracer* self, GumCpuContext* cpu_context, IntPtr return_addresses);
        // [LibraryImport(DllName)]
        // public static unsafe partial void gum_backtracer_generate_with_limit(GumBacktracer* self, GumCpuContext* cpu_context, ref GumReturnAddressArray return_addresses, guint limit);


        /*gum_memory*/
        [LibraryImport(DllName)]
        public static unsafe partial GumMemoryAccessMonitor* gum_memory_access_monitor_new(GumMemoryRange* ranges,
            guint num_ranges, GumPageProtection access_mask, gboolean auto_reset,
            [MarshalAs(UnmanagedType.FunctionPtr)] GumMemoryAccessNotify func, IntPtr data,
            GDestroyNotify data_destroy);

        [LibraryImport(DllName)]
        public static unsafe partial gboolean gum_memory_access_monitor_enable(GumMemoryAccessMonitor* self,
            GError** error);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_memory_access_monitor_disable(GumMemoryAccessMonitor* self);


        [LibraryImport(DllName, EntryPoint = $"g_get_current_dir")]
        public static unsafe partial IntPtr _g_get_current_dir();
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr _frida_g_get_current_dir();

        public static IntPtr g_get_current_dir()
        {
            if (IsWindows)
                return _g_get_current_dir();
            else
                return _frida_g_get_current_dir();
        }


        [LibraryImport(DllName, EntryPoint = $"g_path_get_basename")]
        public static unsafe partial IntPtr _g_path_get_basename(gchar* file_name);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr _frida_g_path_get_basename(gchar* file_name);

        public static unsafe IntPtr g_path_get_basename(gchar* file_name)
        {
            if (IsWindows)
                return _g_path_get_basename(file_name);
            else
                return _frida_g_path_get_basename(file_name);
        }


        [LibraryImport(DllName, EntryPoint = $"g_path_get_dirname")]
        public static unsafe partial IntPtr _g_path_get_dirname(gchar* file_name);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr _frida_g_path_get_dirname(gchar* file_name);

        public static unsafe IntPtr g_path_get_dirname(gchar* file_name)
        {
            if (IsWindows)
                return _g_path_get_dirname(file_name);
            else
                return _frida_g_path_get_dirname(file_name);
        }



        [LibraryImport(DllName, EntryPoint = $"g_get_user_name")]
        public static unsafe partial IntPtr _g_get_user_name();
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr _frida_g_get_user_name();

        public static IntPtr g_get_user_name()
        {
            if (IsWindows)
                return _g_get_user_name();
            else
                return _frida_g_get_user_name();
        }


        [LibraryImport(DllName, EntryPoint = $"g_get_real_name")]
        public static unsafe partial IntPtr _g_get_real_name();
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr _frida_g_get_real_name();

        public static IntPtr g_get_real_name()
        {
            if (IsWindows)
                return _g_get_real_name();
            else
                return _frida_g_get_real_name();
        }


        [LibraryImport(DllName, EntryPoint = $"g_get_home_dir")]
        public static unsafe partial IntPtr _g_get_home_dir();
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr _frida_g_get_home_dir();

        public static IntPtr g_get_home_dir()
        {
            if (IsWindows)
                return _g_get_home_dir();
            else
                return _frida_g_get_home_dir();
        }


        [LibraryImport(DllName, EntryPoint = $"g_get_tmp_dir")]
        public static unsafe partial IntPtr _g_get_tmp_dir();
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr _frida_g_get_tmp_dir();

        public static IntPtr g_get_tmp_dir()
        {
            if (IsWindows)
                return _g_get_tmp_dir();
            else
                return _frida_g_get_tmp_dir();
        }

        [LibraryImport(DllName, EntryPoint = $"g_get_host_name")]
        public static unsafe partial IntPtr _g_get_host_name();
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr _frida_g_get_host_name();

        public static IntPtr g_get_host_name()
        {
            if (IsWindows)
                return _g_get_host_name();
            else
                return _frida_g_get_host_name();
        }


        [LibraryImport(DllName, EntryPoint = $"g_get_application_name")]
        public static unsafe partial IntPtr _g_get_application_name();
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr _frida_g_get_application_name();

        public static IntPtr g_get_application_name()
        {
            if (IsWindows)
                return _g_get_application_name();
            else
                return _frida_g_get_application_name();
        }


        [LibraryImport(DllName, EntryPoint = $"g_filename_display_name")]
        public static unsafe partial IntPtr _g_filename_display_name(IntPtr filename);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr _frida_g_filename_display_name(IntPtr filename);

        public static IntPtr g_filename_display_name(IntPtr filename)
        {
            if (IsWindows)
                return _g_filename_display_name(filename);
            else
                return _frida_g_filename_display_name(filename);
        }



        /*g_bytes*/
        [LibraryImport(DllName, EntryPoint = $"g_bytes_new")]
        public static unsafe partial GBytes* _g_bytes_new(IntPtr data, gsize size);
        [LibraryImport(DllName)]
        public static unsafe partial GBytes* _frida_g_bytes_new(IntPtr data, gsize size);
        public static unsafe GBytes* g_bytes_new(IntPtr data, gsize size)
        {
            if (IsWindows)
                return _g_bytes_new(data, size);
            else
                return _frida_g_bytes_new(data, size);
        }



        [LibraryImport(DllName, EntryPoint = "g_bytes_unref")]
        public static unsafe partial void _g_bytes_unref(GBytes* bytes);
        [LibraryImport(DllName)]
        public static unsafe partial void _frida_g_bytes_unref(GBytes* bytes);
        public static unsafe void g_bytes_unref(GBytes* bytes)
        {
            if (IsWindows)
                g_bytes_unref(bytes);
            else
                _frida_g_bytes_unref(bytes);
        }




        [LibraryImport(DllName)]
        public static unsafe partial void _frida_g_bytes_unref(GBytes* bytes);
        public static unsafe void g_bytes_unref(GBytes* bytes)
        {
            if (IsWindows)
                g_bytes_unref(bytes);
            else
                _frida_g_bytes_unref(bytes);
        }

        [LibraryImport(DllName, EntryPoint = "g_bytes_get_size")]
        public static unsafe partial gsize _g_bytes_get_size(GBytes* bytes);
        [LibraryImport(DllName)]
        public static unsafe partial gsize _frida_g_bytes_get_size(GBytes* bytes);
        public static unsafe gsize g_bytes_get_size(GBytes* bytes)
        {
            if (IsWindows)
                return _g_bytes_get_size(bytes);
            else
                return _frida_g_bytes_get_size(bytes);
        }





        [LibraryImport(DllName, EntryPoint = "g_bytes_get_data")]
        public static unsafe partial IntPtr _g_bytes_get_data(GBytes* bytes, gsize* size);
        [LibraryImport(DllName)]
        public static unsafe partial IntPtr _frida_g_bytes_get_data(GBytes* bytes, gsize* size);
        public static unsafe IntPtr g_bytes_get_data(GBytes* bytes, gsize* size)
        {
            if (IsWindows)
                return _g_bytes_get_data(bytes, size);
            else
                return _frida_g_bytes_get_data(bytes, size);
        }

        /*gum_exceptor*/

        [LibraryImport(DllName)]
        public static unsafe partial void gum_exceptor_disable();

        [LibraryImport(DllName)]
        public static unsafe partial GumExceptor* gum_exceptor_obtain();

        [LibraryImport(DllName)]
        public static unsafe partial void gum_exceptor_reset(GumExceptor* self);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_exceptor_add(GumExceptor* self, void* func,
            void* user_data);

        [LibraryImport(DllName)]
        public static unsafe partial void gum_exceptor_remove(GumExceptor* self, GumExceptionHandler func,
            IntPtr user_data);
        /*g_main_context*/
        [LibraryImport(DllName, EntryPoint = $"g_main_context_get_thread_default")]
        public static unsafe partial GMainContext* _g_main_context_get_thread_default();

        [LibraryImport(DllName)]
        public static unsafe partial GMainContext* _frida_g_main_context_get_thread_default();
        public static unsafe GMainContext* g_main_context_get_thread_default()
        {
            if (IsWindows)
                return _g_main_context_get_thread_default();
            else
                return _frida_g_main_context_get_thread_default();
        }


        [LibraryImport(DllName, EntryPoint = $"g_main_context_pending")]
        public static unsafe partial gboolean _g_main_context_pending(GMainContext* context);
        [LibraryImport(DllName)]
        public static unsafe partial gboolean _frida_g_main_context_pending(GMainContext* context);
        public static unsafe gboolean g_main_context_pending(GMainContext* context)
        {
            if (IsWindows)
                return _g_main_context_pending(context);
            else
                return _frida_g_main_context_pending(context);
        }

    }
}