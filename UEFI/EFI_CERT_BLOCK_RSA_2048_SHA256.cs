using System;
using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode, Size = 640)]
    public struct EFI_CERT_BLOCK_RSA_2048_SHA256 {
        [FieldOffset(0)]
        public Guid HashType;
        [FieldOffset(128)]
        public byte[] PublicKey;
        [FieldOffset(384)]
        public byte[] Signature;

        public static readonly Guid EFI_CERT_TYPE_RSA2048_SHA256_GUID = new(0xa7717414, 0xc616, 0x4977, 0x94, 0x20, 0x84, 0x47, 0x12, 0xa7, 0x35, 0xbf);
        public static readonly Guid EFI_CERT_TYPE_PKCS7_GUID = new(0x4aafd29d, 0x68df, 0x49ee, 0x8a, 0xa9, 0x34, 0x7d, 0x37, 0x56, 0x65, 0xa7);
    };
}
