using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_DEVICE_PATH_PROTOCOL {
        public byte Type;
        public byte SubType;
        public byte Length_1;
        public byte Length_2;
    };
}
