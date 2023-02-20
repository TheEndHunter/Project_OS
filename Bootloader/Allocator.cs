using Efi;

public static class Allocator
{
    private static unsafe EFI_BOOT_SERVICES* bootServices;
    public static unsafe void Initialize(EFI_SYSTEM_TABLE* sysTable)
    {
        bootServices = sysTable->BootServices;
    }
    public static unsafe EFI_STATUS Allocate<T>(T* location, EFI_MEMORY_TYPE memType)
    {
        return bootServices->AllocatePool(memType, (ulong)sizeof(T), (void**)location);
    }
}
