using System;
using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public struct EFI_EVENT {
        private nuint _handle;
        public EFI_EVENT() {
            _handle = UIntPtr.Zero;
        }
        public EFI_EVENT(nuint ptr) {
            _handle = ptr;
        }
        public unsafe EFI_EVENT(void* ptr) {
            _handle = (nuint)ptr;
        }

        public static implicit operator nuint(EFI_EVENT handle) {
            return handle._handle;
        }
        public static unsafe implicit operator void*(EFI_EVENT handle) {
            return (void*)handle._handle;
        }

        public static implicit operator EFI_EVENT(nuint handle) {
            return new EFI_EVENT(handle);
        }
        public static unsafe implicit operator EFI_EVENT(void* handle) {
            return new EFI_EVENT(handle);
        }
    }
}
