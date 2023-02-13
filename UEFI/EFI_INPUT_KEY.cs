using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct EFI_INPUT_KEY
    {
        public readonly ushort ScanCode;
        public readonly char UnicodeChar;
    }
}
