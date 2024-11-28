namespace aadog.PInvoke.LibGum;

// public partial struct GumCore
// {
    // const string DllName = "FridaGumSharedWindows";
    //
    // public unsafe delegate void GObjectFinalize(void* gObject);
    // public unsafe delegate void GDestroyNotify(gpointer data);
    // public unsafe delegate void GFunc(gpointer data, gpointer user_data);
    //
    // public unsafe delegate gboolean GumExceptionHandler(GumExceptionDetails* details, gpointer user_data);
    // public unsafe delegate gboolean GumFoundApiFunc(GumApiDetails* details, gpointer user_data);
    //
    // public unsafe delegate void GumModifyThreadFunc(GumThreadId thread_id,
    //     GumCpuContext* cpu_context, gpointer user_data);
    // public unsafe delegate gboolean GumFoundThreadFunc(GumThreadDetails *details, gpointer user_data);
    //
    // public unsafe delegate gboolean GumFoundModuleFunc(GumModuleDetails* details, gpointer user_data);
    // public unsafe delegate gboolean GumFoundImportFunc(GumImportDetails* details, gpointer user_data);
    // public unsafe delegate gboolean GumFoundExportFunc(GumExportDetails* details, gpointer user_data);
    // public unsafe delegate gboolean GumFoundSymbolFunc(GumSymbolDetails* details, gpointer user_data);
    // public unsafe delegate gboolean GumFoundRangeFunc(GumRangeDetails* details, gpointer user_data);
    // public unsafe delegate gboolean GumFoundSectionFunc(GumSectionDetails* details, gpointer user_data);
    // public unsafe delegate gboolean GumFoundDependencyFunc(GumDependencyDetails* details, gpointer user_data);
    // public unsafe delegate gboolean GumFoundMallocRangeFunc(GumMallocRangeDetails* details, gpointer user_data);
    // // public unsafe delegate gboolean GumResolveExportFunc(gchar* module_name,gchar* symbol_name, gpointer user_data);
    // public unsafe delegate void GumMemoryAccessNotify(GumMemoryAccessMonitor * monitor, GumMemoryAccessDetails * details, gpointer user_data);
    //
    // public unsafe delegate void GumInvocationCallback(GumInvocationContext* context,
    //     gpointer user_data);
    //
    //
    // [DllImport(DllName)]
    // public static extern void g_print([MarshalAs(UnmanagedType.LPUTF8Str)] string format, __arglist);
    //
    // [LibraryImport(DllName)]
    // public static partial void gum_init_embedded();
    //
    // [LibraryImport(DllName)]
    // public static partial void gum_deinit_embedded();
    //
    // [LibraryImport(DllName)]
    // public static partial void gum_init();
    //
    // [LibraryImport(DllName)]
    // public static partial void gum_shutdown();
    //
    // [LibraryImport(DllName)]
    // public static partial void gum_deinit();
    //
    // /*g_error*/
    // [LibraryImport(DllName)]
    // public static unsafe partial void g_error_free(GError* error);
    //
    //
    //
    // /*g_memory*/
    // [LibraryImport(DllName)]
    // public static unsafe partial gpointer g_malloc(gsize n_bytes);
    // [LibraryImport(DllName)]
    // public static unsafe partial void g_free(void* mem);
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial gpointer g_memdup(gpointer mem, guint byte_size);
    //
    //
    // /*gum_memory*/
    // [LibraryImport(DllName)]
    // public static unsafe partial gpointer gum_malloc(gsize size);
    // [LibraryImport(DllName)]
    // public static unsafe partial gpointer gum_calloc (gsize count, gsize size);
    // [LibraryImport(DllName)]
    // public static unsafe partial gpointer gum_realloc (gpointer mem, gsize size);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_free (gpointer mem);
    // [LibraryImport(DllName)]
    // public static unsafe partial gpointer gum_memset (gpointer dst, gint c, gsize n);
    // [LibraryImport(DllName)]
    // public static unsafe partial gpointer gum_memcpy (gpointer dst, gpointer src, gsize n);
    // [LibraryImport(DllName)]
    // public static unsafe partial gpointer gum_memmove (gpointer dst, gpointer src, gsize n);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_mprotect (gpointer address, gsize size, GumPageProtection prot);
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_try_mprotect (gpointer address, gsize size, GumPageProtection prot);
    //
    //
    // /*g_object*/
    // [LibraryImport(DllName)]
    // public static unsafe partial void g_object_ref(gpointer obj);
    // [LibraryImport(DllName)]
    // public static unsafe partial void g_object_unref(gpointer obj);
    // /*g_quark*/
    // [LibraryImport(DllName)]
    // public static unsafe partial char* g_quark_to_string(GQuark quark);
    //
    // /*gum_resolver*/
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial GumApiResolver* gum_api_resolver_make([MarshalAs(UnmanagedType.LPUTF8Str)]string type);
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_api_resolver_enumerate_matches(GumApiResolver* self, [MarshalAs(UnmanagedType.LPUTF8Str)]string query, GumFoundApiFunc func, gpointer user_data,
    //     GError** error);
    //
    //
    // /*gum_process*/
    //
    // [LibraryImport(DllName)]
    // public static partial GumOS gum_process_get_native_os();
    // [LibraryImport(DllName)]
    // public static unsafe partial gchar* gum_process_query_libc_name();
    //
    // [LibraryImport(DllName)]
    // public static partial gboolean gum_process_is_debugger_attached();
    //
    // [LibraryImport(DllName)]
    // public static partial GumProcessId gum_process_get_id();
    //
    // [LibraryImport(DllName)]
    // public static partial GumThreadId gum_process_get_current_thread_id();
    //
    // [LibraryImport(DllName)]
    // public static partial gboolean gum_process_has_thread(GumThreadId thread_id);
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_process_modify_thread(GumThreadId thread_id,
    //     GumModifyThreadFunc func, gpointer user_data, GumModifyThreadFlags flags);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_process_enumerate_threads(GumFoundThreadFunc func,
    //     gpointer user_data);
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial GumModuleDetails* gum_process_get_main_module();
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_process_resolve_module_pointer(gpointer ptr,
    //     gchar** path, GumMemoryRange* range);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_process_enumerate_modules(GumFoundModuleFunc func,
    //     gpointer user_data);
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_process_enumerate_ranges(GumPageProtection prot,
    //     GumFoundRangeFunc func, gpointer user_data);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_process_enumerate_malloc_ranges(GumFoundMallocRangeFunc func, gpointer user_data);
    //
    //
    // /*gum_thread*/
    // [LibraryImport(DllName)]
    // public static unsafe partial gint gum_thread_get_system_error();
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_thread_set_system_error(gint value);
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_thread_suspend(GumThreadId thread_id, GError** error);
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_thread_resume(GumThreadId thread_id, GError** error);
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_thread_set_hardware_breakpoint(GumThreadId thread_id,
    //     guint breakpoint_id, GumAddress address, GError** error);
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_thread_unset_hardware_breakpoint(GumThreadId thread_id,
    //     guint breakpoint_id, GError** error);
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_thread_set_hardware_watchpoint(GumThreadId thread_id,
    //     guint watchpoint_id, GumAddress address, gsize size, GumWatchConditions wc,
    //     GError** error);
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_thread_unset_hardware_watchpoint(GumThreadId thread_id,
    //     guint watchpoint_id, GError** error);
    //
    //
    // /*gum_module*/
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_module_load([MarshalAs(UnmanagedType.LPUTF8Str)] string module_name, GError ** error);
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_module_ensure_initialized([MarshalAs(UnmanagedType.LPUTF8Str)] string module_name);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_module_enumerate_imports([MarshalAs(UnmanagedType.LPUTF8Str)] string module_name, GumFoundImportFunc func,
    //     gpointer user_data);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_module_enumerate_exports([MarshalAs(UnmanagedType.LPUTF8Str)]string module_name, GumFoundExportFunc func,
    //     gpointer user_data);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_module_enumerate_symbols([MarshalAs(UnmanagedType.LPUTF8Str)] string module_name, GumFoundSymbolFunc func,
    //     gpointer user_data);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_module_enumerate_ranges([MarshalAs(UnmanagedType.LPUTF8Str)] string module_name, GumPageProtection prot, GumFoundRangeFunc func,
    //     gpointer user_data);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_module_enumerate_sections([MarshalAs(UnmanagedType.LPUTF8Str)] string module_name, GumFoundSectionFunc prot, 
    //     gpointer user_data);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_module_enumerate_dependencies([MarshalAs(UnmanagedType.LPUTF8Str)] string module_name, GumFoundDependencyFunc prot, 
    //     gpointer user_data);
    // [LibraryImport(DllName)]
    // public static unsafe partial GumAddress gum_module_find_base_address([MarshalAs(UnmanagedType.LPUTF8Str)] string module_name);
    // [LibraryImport(DllName)]
    // public static unsafe partial GumAddress gum_module_find_export_by_name([MarshalAs(UnmanagedType.LPUTF8Str)] string? module_name, [MarshalAs(UnmanagedType.LPUTF8Str)] string symbol_name);
    // [LibraryImport(DllName)]
    // public static unsafe partial GumAddress gum_module_find_symbol_by_name([MarshalAs(UnmanagedType.LPUTF8Str)] string? module_name, [MarshalAs(UnmanagedType.LPUTF8Str)] string symbol_name);
    // [LibraryImport(DllName)]
    // public static unsafe partial gchar* gum_symbol_type_to_string(GumSymbolType type);
    //
    // /*gum_symbol*/
    // [LibraryImport(DllName)]
    // public static unsafe partial gchar* gum_symbol_name_from_address(gpointer address);
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_symbol_details_from_address(gpointer address, GumDebugSymbolDetails* details);
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_return_address_details_from_address(GumReturnAddress address, GumReturnAddressDetails* details);
    //
    // /*gum_interceptor*/
    // [LibraryImport(DllName)]
    // public static unsafe partial GumInterceptor* gum_interceptor_obtain();
    // [LibraryImport(DllName)]
    // public static unsafe partial GumAttachReturn gum_interceptor_attach(GumInterceptor* self,
    //     gpointer function_address, GumInvocationListener* listener,
    //     gpointer listener_function_data);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_interceptor_detach(GumInterceptor* self,
    //     GumInvocationListener* listener);
    // [LibraryImport(DllName)]
    // public static unsafe partial GumReplaceReturn gum_interceptor_replace(GumInterceptor* self,
    //     gpointer function_address, gpointer replacement_function,
    //     gpointer replacement_data, void** original_function);
    // [LibraryImport(DllName)]
    // public static unsafe partial GumReplaceReturn gum_interceptor_replace_fast(GumInterceptor* self,
    //     gpointer function_address, gpointer replacement_function,
    //     void** original_function);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_interceptor_revert(GumInterceptor* self,
    //     gpointer function_address);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_interceptor_begin_transaction(GumInterceptor* self);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_interceptor_end_transaction(GumInterceptor* self);
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_interceptor_flush(GumInterceptor* self);
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial GumInvocationListener* gum_make_call_listener(GumInvocationCallback on_enter, GumInvocationCallback on_leave, gpointer data, GDestroyNotify data_destroy);
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial gpointer gum_invocation_context_get_nth_argument(
    //     GumInvocationContext* context, guint n);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_invocation_context_replace_nth_argument(
    //     GumInvocationContext* context, guint n, gpointer value);
    // [LibraryImport(DllName)]
    // public static unsafe partial gpointer gum_invocation_context_get_return_value(
    //     GumInvocationContext* context);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_invocation_context_replace_return_value(
    //     GumInvocationContext* context, gpointer value);
    // [LibraryImport(DllName)]
    // public static unsafe partial gpointer gum_invocation_context_get_return_address(
    //     GumInvocationContext* context);
    // [LibraryImport(DllName)]
    // public static unsafe partial guint gum_invocation_context_get_thread_id(
    //     GumInvocationContext* context);
    // [LibraryImport(DllName)]
    // public static unsafe partial gpointer gum_invocation_context_get_listener_function_data(GumInvocationContext* context);
    // [LibraryImport(DllName)]
    // public static unsafe partial gpointer gum_invocation_context_get_listener_invocation_data(
    //     GumInvocationContext* context, gsize required_size);
    //     [LibraryImport(DllName)]
    // public static unsafe partial gpointer gum_invocation_context_get_listener_thread_data(
    //     GumInvocationContext* context, gsize required_size);
    // /*gum_backtracer*/
    // [LibraryImport(DllName)]
    // public static unsafe partial GumBacktracer* gum_backtracer_make_accurate();
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial GumBacktracer* gum_backtracer_make_fuzzy();
    //
    // [DllImport(DllName)]
    // public static unsafe extern void gum_backtracer_generate(GumBacktracer* self, GumCpuContext* cpu_context,ref GumReturnAddressArray return_addresses);
    // [DllImport(DllName)]
    // public static unsafe extern void gum_backtracer_generate_with_limit(GumBacktracer* self,GumCpuContext* cpu_context,ref GumReturnAddressArray return_addresses, guint limit);
    //
    //
    //
    //
    //
    // /*gum_memory*/
    // [LibraryImport(DllName)]
    // public static unsafe partial GumMemoryAccessMonitor* gum_memory_access_monitor_new (GumMemoryRange* ranges, guint num_ranges, GumPageProtection access_mask, gboolean auto_reset,[MarshalAs(UnmanagedType.FunctionPtr)]GumMemoryAccessNotify func, gpointer data, GDestroyNotify data_destroy);
    // [LibraryImport(DllName)]
    // public static unsafe partial gboolean gum_memory_access_monitor_enable (GumMemoryAccessMonitor * self, GError ** error);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_memory_access_monitor_disable (GumMemoryAccessMonitor * self);
    //
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial gchar* g_get_current_dir();
    // [LibraryImport(DllName)]
    // public static unsafe partial gchar* g_path_get_basename(gchar* file_name);
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial gchar* g_path_get_dirname(gchar* file_name);
    //
    //
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial gchar* g_get_user_name();
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial gchar* g_get_real_name();
    // [LibraryImport(DllName)]
    // public static unsafe partial gchar* g_get_home_dir();
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial gchar* g_get_tmp_dir();
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial gchar* g_get_host_name();
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial gchar* g_get_application_name();
    // [LibraryImport(DllName)]
    // public static unsafe partial gchar* g_filename_display_name(gchar* filename);
    //
    // /*gum_exceptor*/
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_exceptor_disable();
    // [LibraryImport(DllName)]
    // public static unsafe partial GumExceptor* gum_exceptor_obtain();
    //
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_exceptor_reset(GumException* self);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_exceptor_add(GumExceptor* self, GumExceptionHandler func, gpointer user_data);
    // [LibraryImport(DllName)]
    // public static unsafe partial void gum_exceptor_remove(GumExceptor* self, GumExceptionHandler func,
    //     gpointer user_data);




// }