﻿using System;

namespace Efi
{
    [Flags]
    public enum EFI_RUNTIME_SERVICES_SUPPORTED : uint
    {
        GET_TIME = 0x0001,
        SET_TIME = 0x0002,
        GET_WAKEUP_TIME = 0x0004,
        SET_WAKEUP_TIME = 0x0008,
        GET_VARIABLE = 0x0010,
        GET_NEXT_VARIABLE_NAME = 0x0020,
        SET_VARIABLE = 0x0040,
        SET_VIRTUAL_ADDRESS_MAP = 0x0080,
        CONVERT_POINTER = 0x0100,
        GET_NEXT_HIGH_MONOTONIC_COUNT = 0x0200,
        RESET_SYSTEM = 0x0400,
        UPDATE_CAPSULE = 0x0800,
        QUERY_CAPSULE_CAPABILITIES = 0x1000,
        QUERY_VARIABLE_INFO = 0x2000,
    }
}