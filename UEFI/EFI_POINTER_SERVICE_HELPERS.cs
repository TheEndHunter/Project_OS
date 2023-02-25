namespace Efi {
    public static class EFI_POINTER_SERVICE_HELPERS {
        public const nuint EFI_OPTIONAL_PTR =
#if TARGET_64BIT
                    0x0000000000000001;
#else
            0x00000001;
#endif
    }
}
