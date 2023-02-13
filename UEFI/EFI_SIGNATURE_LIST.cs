using System;
using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential, Size = 640, Pack = 1)]
    public unsafe struct EFI_SIGNATURE_LIST
    {
        public Guid SignatureType;
        public uint SignatureListSize;
        public uint SignatureHeaderSize;
        public uint SignatureSize;
        public byte[] SignatureHeader;
        public EFI_SIGNATURE_DATA[] Signatures;
    }
}