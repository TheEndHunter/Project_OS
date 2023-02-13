using System;
using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential, Size = 640, Pack = 1)]
    public struct EFI_SIGNATURE_DATA
    {
        public Guid SignatureOwner;
        public unsafe byte[] SignatureData;
    }
}
