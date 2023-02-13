using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WIN_CERTIFICATE
    {
        public uint dwLength;
        public ushort wRevision;
        public WIN_CERT_TYPE wCertificateType;
        public unsafe byte[] bCertificate;
    };
}
