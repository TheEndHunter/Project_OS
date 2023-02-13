using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    public struct EFI_MD5_HASH
    {
        [FieldOffset(0)]
        public unsafe fixed byte Data[16];
    }
}