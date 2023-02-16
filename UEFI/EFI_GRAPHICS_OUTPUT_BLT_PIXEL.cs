using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_GRAPHICS_OUTPUT_BLT_PIXEL
    {
        public byte Blue;
        public byte Green;
        public byte Red;
        public byte Reserved;
    }
}
