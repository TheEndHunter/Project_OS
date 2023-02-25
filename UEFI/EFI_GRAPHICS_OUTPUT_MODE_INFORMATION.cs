using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_GRAPHICS_OUTPUT_MODE_INFORMATION {
        public uint Version;
        public uint HorizontalResolution;
        public uint VerticalResolution;
        public EFI_GRAPHICS_PIXEL_FORMAT PixelFormat;
        public EFI_PIXEL_BITMASK PixelInformation;
        public uint PixelsPerScanLine;
    }
}
