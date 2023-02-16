using System;

namespace Efi
{
    public static class UEFI
    {
        public static class GUIDs
        {
            public static class PROTOCOL
            {
                public static readonly Guid EFI_GRAPHICS_OUTPUT_PROTOCOL = new() { a = 0x9042a9de, b = 0x23dc, c = 0x4a38, d = 0x96, e = 0xfb, f = 0x7a, g = 0xde, h = 0xd0, i = 0x80, j = 0x51, k = 0x6a };
                public static readonly Guid EFI_SIMPLE_TEXT_INPUT_PROTOCOL_GUID = new() { a = 0x387477c1, b = 0x69c7, c = 0x11d2, d = 0x8e, e = 0x39, f = 0x00, g = 0xa0, h = 0xc9, i = 0x69, j = 0x72, k = 0x3b };
                public static readonly Guid EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL_GUID = new() { a = 0x387477c2, b = 0x69c7, c = 0x11d2, d = 0x8e, e = 0x39, f = 0x00, g = 0xa0, h = 0xc9, i = 0x69, j = 0x72, k = 0x3b };
            }
            public static class EVENT_GROUP
            {
                public static readonly Guid EFI_EVENT_GROUP_EXIT_BOOT_SERVICES = new(0x27abf055, 0xb1b8, 0x4c26, 0x80, 0x48, 0x74, 0x8f, 0x37, 0xba, 0xa2, 0xdf);
                public static readonly Guid EFI_EVENT_GROUP_BEFORE_EXIT_BOOT_SERVICES = new(0x8be0e274, 0x3970, 0x4b44, 0x80, 0xc5, 0x1a, 0xb9, 0x50, 0x2f, 0x3b, 0xfc);
                public static readonly Guid EFI_EVENT_GROUP_VIRTUAL_ADDRESS_CHANGE = new(0x13fa7698, 0xc831, 0x49c7, 0x87, 0xea, 0x8f, 0x43, 0xfc, 0xc2, 0x51, 0x96);
                public static readonly Guid EFI_EVENT_GROUP_MEMORY_MAP_CHANGE = new(0x78bee926, 0x692f, 0x48fd, 0x9e, 0xdb, 0x1, 0x42, 0x2e, 0xf0, 0xd7, 0xab);
                public static readonly Guid EFI_EVENT_GROUP_READY_TO_BOOT = new(0x7ce88fb3, 0x4bd7, 0x4679, 0x87, 0xa8, 0xa8, 0xd8, 0xde, 0xe5, 0xd, 0x2b);
                public static readonly Guid EFI_EVENT_GROUP_AFTER_READY_TO_BOOT = new(0x3a2a00ad, 0x98b9, 0x4cdf, 0xa4, 0x78, 0x70, 0x27, 0x77, 0xf1, 0xc1, 0xb);
                public static readonly Guid EFI_EVENT_GROUP_RESET_SYSTEM = new(0x62da6a56, 0x13fb, 0x485a, 0xa8, 0xda, 0xa3, 0xdd, 0x79, 0x12, 0xcb, 0x6b);
            }
            public static class DEVICE_TREE_TABLE
            {
                public static readonly Guid EFI_DTB_TABLE_GUID = new(0xb1b621d5, 0xf19c, 0x41a5, 0x83, 0x0b, 0xd9, 0x15, 0x2c, 0x69, 0xaa, 0xe0);
            }
            public static class CERT
            {
                public static readonly Guid EFI_CERT_EXTERNAL_MANAGEMENT_GUID = new(0x452e8ced, 0xdfff, 0x4b8c, 0xae, 0x01, 0x51, 0x18, 0x86, 0x2e, 0x68, 0x2c);
                public static readonly Guid EFI_CERT_X509_SHA512_GUID = new(0x446dbf63, 0x2502, 0x4cda, 0xbc, 0xfa, 0x24, 0x65, 0xd2, 0xb0, 0xfe, 0x9d);
                public static readonly Guid EFI_CERT_X509_SHA384_GUID = new(0x7076876e, 0x80c2, 0x4ee6, 0xaa, 0xd2, 0x28, 0xb3, 0x49, 0xa6, 0x86, 0x5b);
                public static readonly Guid EFI_CERT_X509_SHA256_GUID = new(0x3bd2a492, 0x96c0, 0x4079, 0xb4, 0x20, 0xfc, 0xf9, 0x8e, 0xf1, 0x03, 0xed);
                public static readonly Guid EFI_CERT_SHA512_GUID = new(0x93e0fae, 0xa6c4, 0x4f50, 0x9f, 0x1b, 0xd4, 0x1e, 0x2b, 0x89, 0xc1, 0x9a);
                public static readonly Guid EFI_CERT_SHA384_GUID = new(0xff3e5307, 0x9fd0, 0x48c9, 0x85, 0xf1, 0x8a, 0xd5, 0x6c, 0x70, 0x1e, 0x01);
                public static readonly Guid EFI_CERT_SHA224_GUID = new(0xb6e5233, 0xa65c, 0x44c9, 0x94, 0x07, 0xd9, 0xab, 0x83, 0xbf, 0xc8, 0xbd);
                public static readonly Guid EFI_CERT_X509_GUID = new(0xa5c059a1, 0x94e4, 0x4aa7, 0x87, 0xb5, 0xab, 0x15, 0x5c, 0x2b, 0xf0, 0x72);
                public static readonly Guid EFI_CERT_RSA2048_SHA1_GUID = new(0x67f8444f, 0x8743, 0x48f1, 0xa3, 0x28, 0x1e, 0xaa, 0xb8, 0x73, 0x60, 0x80);
                public static readonly Guid EFI_CERT_SHA1_GUID = new(0x826ca512, 0xcf10, 0x4ac9, 0xb1, 0x87, 0xbe, 0x01, 0x49, 0x66, 0x31, 0xbd);
                public static readonly Guid EFI_CERT_RSA2048_SHA256_GUID = new(0xe2b36190, 0x879b, 0x4a3d, 0xad, 0x8d, 0xf2, 0xe7, 0xbb, 0xa3, 0x27, 0x84);
                public static readonly Guid EFI_CERT_RSA2048_GUID = new(0x3c5766e8, 0x269c, 0x4e34, 0xaa, 0x14, 0xed, 0x77, 0x6e, 0x85, 0xb3, 0xb6);
                public static readonly Guid EFI_CERT_SHA256_GUID = new(0xc1c41626, 0x504c, 0x4092, 0xac, 0xa9, 0x41, 0xf9, 0x36, 0x93, 0x43, 0x28);
            }

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
