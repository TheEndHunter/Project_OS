using System;
using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_HANDLE {
        private nint _handle;

        public EFI_HANDLE() {
            _handle = IntPtr.Zero;
        }
        public EFI_HANDLE(nint ptr) {
            _handle = ptr;
        }
        public unsafe EFI_HANDLE(void* ptr) {
            _handle = (nint)ptr;
        }

        public static implicit operator nint(EFI_HANDLE handle) {
            return handle._handle;
        }
        public static unsafe implicit operator void*(EFI_HANDLE handle) {
            return (void*)handle._handle;
        }

        public static implicit operator EFI_HANDLE(nint handle) {
            return new EFI_HANDLE(handle);
        }
        public static unsafe implicit operator EFI_HANDLE(void* handle) {
            return new EFI_HANDLE(handle);
        }
    }
}
