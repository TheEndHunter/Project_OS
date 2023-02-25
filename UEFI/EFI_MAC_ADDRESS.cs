using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode, Size = 32)]
    public struct EFI_MAC_ADDRESS {
        [FieldOffset(0)]
        public unsafe fixed byte Data[32];
    }
}