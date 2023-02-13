using System;
using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WIN_CERTIFICATE_EFI_PKCS1_15
    {
        public WIN_CERTIFICATE Hdr;
        public Guid HashAlgorithm;
        public unsafe byte[] Signature;
    }
}
