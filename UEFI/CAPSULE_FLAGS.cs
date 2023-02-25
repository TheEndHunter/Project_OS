using System;

namespace Efi {
    [Flags]
    public enum CAPSULE_FLAGS : uint {
        CAPSULE_FLAGS_PERSIST_ACROSS_RESET = 0x00010000,
        CAPSULE_FLAGS_POPULATE_SYSTEM_TABLE = 0x00020000,
        CAPSULE_FLAGS_INITIATE_RESET = 0x00040000,
    }
}
