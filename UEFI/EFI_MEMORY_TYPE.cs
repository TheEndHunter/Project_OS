﻿namespace Efi
{
    public enum EFI_MEMORY_TYPE
    {
        EfiReservedMemoryType,
        EfiLoaderCode,
        EfiLoaderData,
        EfiBootServicesCode,
        EfiBootServicesData,
        EfiRuntimeServicesCode,
        EfiRuntimeServicesData,
        EfiConventionalMemory,
        EfiUnusableMemory,
        EfiACPIReclaimMemory,
        EfiACPIMemoryNVS,
        EfiMemoryMappedIO,
        EfiMemoryMappedIOPortSpace,
        EfiPalCode,
        EfiPersistentMemory,
        EfiUnacceptedMemoryType,
        EfiMaxMemoryType,
    };
}
