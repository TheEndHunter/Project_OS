using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    public unsafe struct EFI_SHA384_HASH {
        [FieldOffset(0)]
        public fixed byte Data[48];
    }
}