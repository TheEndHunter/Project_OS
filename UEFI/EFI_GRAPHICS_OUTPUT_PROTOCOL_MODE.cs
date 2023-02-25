using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct EFI_GRAPHICS_OUTPUT_PROTOCOL_MODE {
        public uint MaxMode;
        public uint Mode;
        public EFI_GRAPHICS_OUTPUT_MODE_INFORMATION* Info;
        public UIntn SizeOfInfo;
        public EFI_PHYSICAL_ADDRESS FrameBufferBase;
        public UIntn FrameBufferSize;
    }
}
