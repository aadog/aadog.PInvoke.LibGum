using System.Runtime.InteropServices;
using aadog.PInvoke.LibGum.Enums;

namespace aadog.PInvoke.LibGum
{ 
    public partial class LibGum
    {
        const string DllName = "Gum";
#if Windows
        private const string Frida_LibPrefix = "";
#else
        private const string Frida_LibPrefix = "_frida_";
#endif

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


        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_print")]
        public static partial void g_print([MarshalAs(UnmanagedType.LPUTF8Str)] string format);

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
        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_error_free")]
        public static unsafe partial void g_error_free(GError* error);

        /*g_memory*/
        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_malloc")]
        public static unsafe partial IntPtr g_malloc(gsize n_bytes);

        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_free")]
        public static unsafe partial void g_free(IntPtr mem);

        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_get_memdup")]
        public static unsafe partial IntPtr g_memdup(IntPtr mem, guint byte_size);


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
        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_object_ref")]
        public static unsafe partial void g_object_ref(gpointer obj);

        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_object_unref")]
        public static unsafe partial void g_object_unref(gpointer obj);

        /*g_quark*/
        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_quark_to_string")]
        public static unsafe partial char* g_quark_to_string(GQuark quark);


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


        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_get_current_dir")]
        public static unsafe partial IntPtr g_get_current_dir();

        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_path_get_basename")]
        public static unsafe partial IntPtr g_path_get_basename(gchar* file_name);

        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_path_get_dirname")]
        public static unsafe partial IntPtr g_path_get_dirname(gchar* file_name);


        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_get_user_name")]
        public static unsafe partial IntPtr g_get_user_name();

        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_get_real_name")]
        public static unsafe partial IntPtr g_get_real_name();

        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_get_home_dir")]
        public static unsafe partial IntPtr g_get_home_dir();

        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_get_tmp_dir")]
        public static unsafe partial IntPtr g_get_tmp_dir();

        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_get_host_name")]
        public static unsafe partial IntPtr g_get_host_name();

        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_get_application_name")]
        public static unsafe partial IntPtr g_get_application_name();

        [LibraryImport(DllName, EntryPoint = $"{Frida_LibPrefix}g_filename_display_name")]
        public static unsafe partial IntPtr g_filename_display_name(IntPtr filename);

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
    }
}