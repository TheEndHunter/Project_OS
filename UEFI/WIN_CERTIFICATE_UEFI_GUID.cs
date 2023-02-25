using System;
using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public struct WIN_CERTIFICATE_UEFI_GUID {
        public WIN_CERTIFICATE Hdr;
        public Guid CertType;
        public unsafe byte[] CertData;
    }
}
