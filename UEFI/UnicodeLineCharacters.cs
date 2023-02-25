using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public static class UnicodeLineCharacters {
        public const char UNICODE_NULL = (char)(ushort)0x0000;
        public const char UNICODE_BACK_SPACE = (char)(ushort)0x0008;
        public const char UNICODE_LINE_FEED = (char)(ushort)0x000A;
        public const char UNICODE_CARRIAGE_RETURN = (char)(ushort)0x000D;
    }
}
