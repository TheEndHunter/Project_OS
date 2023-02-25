using System;
using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_CAPSULE_HEADER {
        public Guid CapsuleGuid;
        public uint HeaderSize;
        public CAPSULE_FLAGS Flags;
        public uint CapsuleImageSize;
    }
}
