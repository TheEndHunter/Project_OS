using System;
using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct EFI_SIMPLE_TEXT_INPUT_PROTOCOL
    {
        public readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_PROTOCOL*, bool, EFI_STATUS> Reset;
        public readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_PROTOCOL*, EFI_INPUT_KEY*, EFI_STATUS> ReadKeyStroke;
        public readonly EFI_EVENT WaitForKey;
    }
}
