using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_MEMORY_DESCRIPTOR
    {
        public uint Type;
        public EFI_PHYSICAL_ADDRESS PhysicalStart;
        public EFI_VIRTUAL_ADDRESS VirtualStart;
        public ulong NumberOfPages;
        public ulong Attribute;
        public const nint EFI_MEMORY_DESCRIPTOR_VERSION = 1;
    };
}
