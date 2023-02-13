using System;

namespace Efi
{
    public static class UEFI
    {
        public static class GUIDs
        {
            public static readonly Guid EFI_SIMPLE_TEXT_INPUT_PROTOCOL_GUID = new(0x387477c1, 0x69c7, 0x11d2, 0x8e, 0x39, 0x00, 0xa0, 0xc9, 0x69, 0x72, 0x3b);
            public static readonly Guid EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL_GUID = new(0x387477c2, 0x69c7, 0x11d2, 0x8e, 0x39, 0x00, 0xa0, 0xc9, 0x69, 0x72, 0x3b);

            public static readonly Guid EFI_RT_PROPERTIES_TABLE_GUID = new(0xeb66918a, 0x7eef, 0x402a, 0x84, 0x2e, 0x93, 0x1d, 0x21, 0xc3, 0x8a, 0xe9);
            public static readonly Guid EFI_JSON_CONFIG_DATA_TABLE_GUID = new(0x87367f87, 0x1119, 0x41ce, 0xaa, 0xec, 0x8b, 0xe0, 0x11, 0x1f, 0x55, 0x8a);
            public static readonly Guid EFI_JSON_CAPSULE_DATA_TABLE_GUID = new(0x35e7a725, 0x8dd2, 0x4cac, 0x80, 0x11, 0x33, 0xcd, 0xa8, 0x10, 0x90, 0x56);
            public static readonly Guid EFI_JSON_CAPSULE_RESULT_TABLE_GUID = new(0xdbc461c3, 0xb3de, 0x422a, 0xb9, 0xb4, 0x98, 0x86, 0xfd, 0x49, 0xa1, 0xe5);

            public static readonly Guid SAL_SYSTEM_TABLE_GUID = new(0xeb9d2d32, 0x2d88, 0x11d3, 0x9a, 0x16, 0x00, 0x90, 0x27, 0x3f, 0xc1, 0x4d);
            public static readonly Guid SMBIOS_TABLE_GUID = new(0xeb9d2d31, 0x2d88, 0x11d3, 0x9a, 0x16, 0x00, 0x90, 0x27, 0x3f, 0xc1, 0x4d);
            public static readonly Guid SMBIOS3_TABLE_GUID = new(0xf2fd1544, 0x9794, 0x4a2c, 0x99, 0x2e, 0xe5, 0xbb, 0xcf, 0x20, 0xe3, 0x94);
            public static readonly Guid MPS_TABLE_GUID = new(0xeb9d2d2f, 0x2d88, 0x11d3, 0x9a, 0x16, 0x00, 0x90, 0x27, 0x3f, 0xc1, 0x4d);
            //
            // ACPI 2.0 or newer tables should use EFI_ACPI_TABLE_GUID
            //
            public static readonly Guid EFI_ACPI_TABLE_GUID = new(0x8868e871, 0xe4f1, 0x11d3, 0xbc, 0x22, 0x00, 0x80, 0xc7, 0x3c, 0x88, 0x81);
            public static readonly Guid EFI_ACPI_20_TABLE_GUID = EFI_ACPI_TABLE_GUID;
            public static readonly Guid ACPI_TABLE_GUID = new(0xeb9d2d30, 0x2d88, 0x11d3, 0x9a, 0x16, 0x00, 0x90, 0x27, 0x3f, 0xc1, 0x4d);
            public static readonly Guid ACPI_10_TABLE_GUID = ACPI_TABLE_GUID;
        }
        public const ulong EFI_SYSTEM_TABLE_SIGNATURE = 0x5453595320494249;
        public const uint EFI_2_90_SYSTEM_TABLE_REVISION = ((2 << 16) | (90));
        public const uint EFI_2_80_SYSTEM_TABLE_REVISION = ((2 << 16) | (80));
        public const uint EFI_2_70_SYSTEM_TABLE_REVISION = ((2 << 16) | (70));
        public const uint EFI_2_60_SYSTEM_TABLE_REVISION = ((2 << 16) | (60));
        public const uint EFI_2_50_SYSTEM_TABLE_REVISION = ((2 << 16) | (50));
        public const uint EFI_2_40_SYSTEM_TABLE_REVISION = ((2 << 16) | (40));
        public const uint EFI_2_31_SYSTEM_TABLE_REVISION = ((2 << 16) | (31));
        public const uint EFI_2_30_SYSTEM_TABLE_REVISION = ((2 << 16) | (30));
        public const uint EFI_2_20_SYSTEM_TABLE_REVISION = ((2 << 16) | (20));
        public const uint EFI_2_10_SYSTEM_TABLE_REVISION = ((2 << 16) | (10));
        public const uint EFI_2_00_SYSTEM_TABLE_REVISION = ((2 << 16) | (00));
        public const uint EFI_1_10_SYSTEM_TABLE_REVISION = ((1 << 16) | (10));
        public const uint EFI_1_02_SYSTEM_TABLE_REVISION = ((1 << 16) | (02));
        public const uint EFI_SYSTEM_TABLE_REVISION = EFI_2_90_SYSTEM_TABLE_REVISION;
        public const uint EFI_SPECIFICATION_VERSION = EFI_SYSTEM_TABLE_REVISION;
        public const ulong EFI_BOOT_SERVICES_SIGNATURE = 0x56524553544f4f42;
        public const ulong EFI_BOOT_SERVICES_REVISION = EFI_SPECIFICATION_VERSION;

        public static byte CreateColor(EFI_TEXT_COLOR textColor, EFI_BACKGROUND_COLOR backgroundColor) => (byte)((byte)backgroundColor & (byte)textColor);
    }
}
