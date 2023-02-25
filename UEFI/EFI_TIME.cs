using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_TIME {
        public ushort Year; // 1900 – 9999
        public byte Month; // 1 – 12
        public byte Day; // 1 – 31
        public byte Hour; // 0 – 23
        public byte Minute; // 0 – 59
        public byte Second; // 0 – 59
        public byte Pad1;
        public uint Nanosecond; // 0 – 999,999,999
        public short TimeZone; // -1440 to 1440 or 2047
        public EFI_TIME_DAYLIGHT Daylight;
        public byte Pad2;

        public const short EFI_UNSPECIFIED_TIMEZONE = 0x07FF;
    }
}
