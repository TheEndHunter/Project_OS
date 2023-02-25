using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct EFI_RT_PROPERTIES_TABLE {
        public readonly ushort Version;
        public readonly ushort Length;
        public readonly uint RuntimeServicesSupported;
        public static readonly ushort EFI_RT_PROPERTIES_TABLE_VERSION = 0x1;
    }
}
