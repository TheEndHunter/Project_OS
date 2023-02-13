using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public static class UnicodeDrawingCharacters
    {
        public const char BOXDRAW_HORIZONTAL = (char)(ushort)0x2500;
        public const char BOXDRAW_VERTICAL = (char)(ushort)0x2502;
        public const char BOXDRAW_DOWN_RIGHT = (char)(ushort)0x250c;
        public const char BOXDRAW_DOWN_LEFT = (char)(ushort)0x2510;
        public const char BOXDRAW_UP_RIGHT = (char)(ushort)0x2514;
        public const char BOXDRAW_UP_LEFT = (char)(ushort)0x2518;
        public const char BOXDRAW_VERTICAL_RIGHT = (char)(ushort)0x251c;
        public const char BOXDRAW_VERTICAL_LEFT = (char)(ushort)0x2524;
        public const char BOXDRAW_DOWN_HORIZONTAL = (char)(ushort)0x252c;
        public const char BOXDRAW_UP_HORIZONTAL = (char)(ushort)0x2534;
        public const char BOXDRAW_VERTICAL_HORIZONTAL = (char)(ushort)0x253c;
        public const char BOXDRAW_DOUBLE_HORIZONTAL = (char)(ushort)0x2550;
        public const char BOXDRAW_DOUBLE_VERTICAL = (char)(ushort)0x2551;
        public const char BOXDRAW_DOWN_RIGHT_DOUBLE = (char)(ushort)0x2552;
        public const char BOXDRAW_DOWN_DOUBLE_RIGHT = (char)(ushort)0x2553;
        public const char BOXDRAW_DOUBLE_DOWN_RIGHT = (char)(ushort)0x2554;
        public const char BOXDRAW_DOWN_LEFT_DOUBLE = (char)(ushort)0x2555;
        public const char BOXDRAW_DOWN_DOUBLE_LEFT = (char)(ushort)0x2556;
        public const char BOXDRAW_DOUBLE_DOWN_LEFT = (char)(ushort)0x2557;
        public const char BOXDRAW_UP_RIGHT_DOUBLE = (char)(ushort)0x2558;
        public const char BOXDRAW_UP_DOUBLE_RIGHT = (char)(ushort)0x2559;
        public const char BOXDRAW_DOUBLE_UP_RIGHT = (char)(ushort)0x255a;
        public const char BOXDRAW_UP_LEFT_DOUBLE = (char)(ushort)0x255b;
        public const char BOXDRAW_UP_DOUBLE_LEFT = (char)(ushort)0x255c;
        public const char BOXDRAW_DOUBLE_UP_LEFT = (char)(ushort)0x255d;
        public const char BOXDRAW_VERTICAL_RIGHT_DOUBLE = (char)(ushort)0x255e;
        public const char BOXDRAW_VERTICAL_DOUBLE_RIGHT = (char)(ushort)0x255f;
        public const char BOXDRAW_DOUBLE_VERTICAL_RIGHT = (char)(ushort)0x2560;
        public const char BOXDRAW_VERTICAL_LEFT_DOUBLE = (char)(ushort)0x2561;
        public const char BOXDRAW_VERTICAL_DOUBLE_LEFT = (char)(ushort)0x2562;
        public const char BOXDRAW_DOUBLE_VERTICAL_LEFT = (char)(ushort)0x2563;
        public const char BOXDRAW_DOWN_HORIZONTAL_DOUBLE = (char)(ushort)0x2564;
        public const char BOXDRAW_DOWN_DOUBLE_HORIZONTAL = (char)(ushort)0x2565;
        public const char BOXDRAW_DOUBLE_DOWN_HORIZONTAL = (char)(ushort)0x2566;
        public const char BOXDRAW_UP_HORIZONTAL_DOUBLE = (char)(ushort)0x2567;
        public const char BOXDRAW_UP_DOUBLE_HORIZONTAL = (char)(ushort)0x2568;
        public const char BOXDRAW_DOUBLE_UP_HORIZONTAL = (char)(ushort)0x2569;
        public const char BOXDRAW_VERTICAL_HORIZONTAL_DOUBLE = (char)(ushort)0x256a;
        public const char BOXDRAW_VERTICAL_DOUBLE_HORIZONTAL = (char)(ushort)0x256b;
        public const char BOXDRAW_DOUBLE_VERTICAL_HORIZONTAL = (char)(ushort)0x256c;
        //*******************************************************
        // EFI Required Block Elements Code Chart
        //*******************************************************
        public const char BLOCKELEMENT_FULL_BLOCK = (char)(ushort)0x2588;
        public const char BLOCKELEMENT_LIGHT_SHADE = (char)(ushort)0x2591;
        //*******************************************************
        // EFI Required Geometric Shapes Code Chart
        //*******************************************************
        public const char GEOMETRICSHAPE_UP_TRIANGLE = (char)(ushort)0x25b2;
        public const char GEOMETRICSHAPE_RIGHT_TRIANGLE = (char)(ushort)0x25ba;
        public const char GEOMETRICSHAPE_DOWN_TRIANGLE = (char)(ushort)0x25bc;
        public const char GEOMETRICSHAPE_LEFT_TRIANGLE = (char)(ushort)0x25c4;
        //*******************************************************
        // EFI Required Arrow shapes
        //*******************************************************
        public const char ARROW_UP = (char)(ushort)0x2191;
        public const char ARROW_DOWN = (char)(ushort)0x2193;
    }
}
