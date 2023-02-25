using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_VARIABLE_AUTHENTICATION_2 {
        public EFI_TIME TimeStamp;
        public WIN_CERTIFICATE_UEFI_GUID AuthInfo;
    }
}
