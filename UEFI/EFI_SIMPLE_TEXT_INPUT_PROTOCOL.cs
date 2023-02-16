using System;
using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct EFI_SIMPLE_TEXT_INPUT_PROTOCOL
    {
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_PROTOCOL*, bool, EFI_STATUS> _Reset;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_INPUT_PROTOCOL*, EFI_INPUT_KEY*, EFI_STATUS> _ReadKeyStroke;
        private readonly EFI_EVENT _WaitForKey;

        public EFI_STATUS Reset(bool verify = false)
        {
            fixed (EFI_SIMPLE_TEXT_INPUT_PROTOCOL* s = &this)
            {
                return _Reset(s, verify);
            }
        }

        public EFI_STATUS ReadKeyStroke(EFI_INPUT_KEY* key)
        {
            fixed (EFI_SIMPLE_TEXT_INPUT_PROTOCOL* s = &this)
            {
                return _ReadKeyStroke(s, key);
            }
        }

        public EFI_EVENT WaitForKey => _WaitForKey;
    }
}
