using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_OPEN_PROTOCOL_INFORMATION_ENTRY
    {
        public EFI_HANDLE AgentHandle;
        public EFI_HANDLE ControllerHandle;
        public uint Attributes;
        public uint OpenCount;
    }
}
