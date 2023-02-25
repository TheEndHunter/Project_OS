using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct EFI_KEY_STATE {
        public readonly EFI_KEY_SHIFT_STATE KeyShiftState;
        public readonly EFI_KEY_TOGGLE_STATE KeyToggleState;
    }
}
