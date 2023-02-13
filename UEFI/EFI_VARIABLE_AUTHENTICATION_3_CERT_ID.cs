using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]

    public struct EFI_VARIABLE_AUTHENTICATION_3_CERT_ID
    {
        public byte Type;
        public uint IdSize;
        public byte[] Id;

        public const int EFI_VARIABLE_AUTHENTICATION_3_CERT_ID_SHA256 = 1;
    }
            ;
}
