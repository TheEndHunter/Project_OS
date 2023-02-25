using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_CAPSULE_BLOCK_DESCRIPTOR {
        public ulong Length;
        public CapsuleUnion Union;
    }
}
