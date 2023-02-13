using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    public struct CapsuleUnion
    {
        [FieldOffset(0)]
        public EFI_PHYSICAL_ADDRESS DataBlock;
        [FieldOffset(0)]
        public EFI_PHYSICAL_ADDRESS ContinuationPointer;
    }
}
