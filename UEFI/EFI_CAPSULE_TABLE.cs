using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_CAPSULE_TABLE
    {
        public uint CapsuleArrayNumber;
        public unsafe void* CapsulePtr;
    }
}
