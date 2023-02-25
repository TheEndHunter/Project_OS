using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_VARIABLE_AUTHENTICATION_3 {
        public byte Version;
        public byte Type;
        public uint MetadataSize;
        public uint Flags;
        public const int EFI_VARIABLE_AUTHENTICATION_3_TIMESTAMP_TYPE = 1;
        public const int EFI_VARIABLE_AUTHENTICATION_3_NONCE_TYPE = 2;
    }
}
