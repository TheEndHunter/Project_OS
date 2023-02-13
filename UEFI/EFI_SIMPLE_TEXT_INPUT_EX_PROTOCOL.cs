using System;
using System.Runtime.InteropServices;

namespace Efi
{
    public unsafe delegate EFI_STATUS EFI_KEY_DATA_NOTIFY_FUNCTION(EFI_KEY_DATA* KeyData);

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL
    {
        public readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL*, bool, EFI_STATUS> Reset;
        public readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL*, EFI_KEY_DATA*, EFI_STATUS> ReadKeyStrokeEx;
        public readonly EFI_EVENT WaitForKeyEx;
        public readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL*, EFI_KEY_TOGGLE_STATE*, EFI_STATUS> SetState;
        public readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL*, EFI_KEY_DATA*, EFI_KEY_DATA_NOTIFY_FUNCTION, void**, EFI_STATUS> RegisterKeyNotify;
        public readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL*, void*, EFI_STATUS> UnregisterKeyNotify;
        public static readonly Guid EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL_GUID = new(0xdd9e7534, 0x7762, 0x4698, 0x8c, 0x14, 0xf5, 0x85, 0x17, 0xa6, 0x25, 0xaa);
    }
}
