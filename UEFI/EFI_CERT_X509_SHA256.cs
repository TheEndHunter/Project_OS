using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct EFI_CERT_X509_SHA256 {
        EFI_SHA256_HASH ToBeSignedHash;
        EFI_TIME TimeOfRevocation;
    }
}
