using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_VARIABLE_AUTHENTICATION {
        public ulong MonotonicCount;
        public WIN_CERTIFICATE_UEFI_GUID AuthInfo;
    }
}
