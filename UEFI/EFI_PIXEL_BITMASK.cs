using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_PIXEL_BITMASK
    {
        public uint RedMask;
        public uint GreenMask;
        public uint BlueMask;
        public uint ReservedMask;
    };
}
