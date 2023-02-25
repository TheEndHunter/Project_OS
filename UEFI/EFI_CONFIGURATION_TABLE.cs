using System;
using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct EFI_CONFIGURATION_TABLE {
        public readonly Guid VendorGuid;
        public readonly void* VendorTable;
    }
}
