using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct EFI_TIME_CAPABILITIES
    {
        public readonly uint Resolution;
        public readonly uint Accuracy;
        public readonly bool SetsToZero;
    };
}
