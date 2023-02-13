using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public unsafe struct EFI_IPv4_ADDRESS
    {
        public fixed byte Address[4];
    }
}
