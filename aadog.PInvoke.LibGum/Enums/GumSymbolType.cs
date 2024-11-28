﻿namespace aadog.PInvoke.LibGum.Enums;


public enum GumSymbolType
{
    /* Common */
    GUM_SYMBOL_UNKNOWN,
    GUM_SYMBOL_SECTION,

    /* Mach-O */
    GUM_SYMBOL_UNDEFINED,
    GUM_SYMBOL_ABSOLUTE,
    GUM_SYMBOL_PREBOUND_UNDEFINED,
    GUM_SYMBOL_INDIRECT,

    /* ELF */
    GUM_SYMBOL_OBJECT,
    GUM_SYMBOL_FUNCTION,
    GUM_SYMBOL_FILE,
    GUM_SYMBOL_COMMON,
    GUM_SYMBOL_TLS,
};