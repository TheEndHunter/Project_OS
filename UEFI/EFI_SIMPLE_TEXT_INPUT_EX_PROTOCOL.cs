using System;
using System.Runtime.InteropServices;

namespace Efi {
    public unsafe delegate EFI_STATUS EFI_KEY_DATA_NOTIFY_FUNCTION(EFI_KEY_DATA* KeyData);

    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL {
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL*, bool, EFI_STATUS> _Reset;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL*, EFI_KEY_DATA*, EFI_STATUS> _ReadKeyStrokeEx;
        private readonly EFI_EVENT _WaitForKeyEx;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL*, EFI_KEY_TOGGLE_STATE*, EFI_STATUS> _SetState;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL*, EFI_KEY_DATA*, EFI_KEY_DATA_NOTIFY_FUNCTION, void**, EFI_STATUS> _RegisterKeyNotify;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL*, void*, EFI_STATUS> _UnregisterKeyNotify;
        public static readonly Guid EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL_GUID = new(0xdd9e7534, 0x7762, 0x4698, 0x8c, 0x14, 0xf5, 0x85, 0x17, 0xa6, 0x25, 0xaa);

        public EFI_STATUS Reset(bool verify) {
            fixed (EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL* s = &this) {
                return _Reset(s, verify);
            }

        }

        public EFI_STATUS ReadKeyStroke(EFI_KEY_DATA* key) {
            fixed (EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL* s = &this) {
                return _ReadKeyStrokeEx(s, key);
            }

        }
        public EFI_STATUS SetState(EFI_KEY_TOGGLE_STATE* state) {
            fixed (EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL* s = &this) {
                return _SetState(s, state);
            }
        }
        public EFI_STATUS SetState(EFI_KEY_TOGGLE_STATE state) {
            fixed (EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL* s = &this) {
                return _SetState(s, &state);
            }
        }

        public EFI_STATUS RegisterKeyNotify(EFI_KEY_DATA* key, EFI_KEY_DATA_NOTIFY_FUNCTION func, void** a) {
            fixed (EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL* s = &this) {
                return _RegisterKeyNotify(s, key, func, a);
            }
        }
        public EFI_STATUS UnregisterKeyNotify(void* a) {
            fixed (EFI_SIMPLE_TEXT_INPUT_EX_PROTOCOL* s = &this) {
                return _UnregisterKeyNotify(s, a);
            }
        }
        public EFI_EVENT WaitForKey => _WaitForKeyEx;
    }
}
