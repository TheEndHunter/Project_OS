using System;
using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public static class DEVICETREE_TABLES_GUIDS
    {
        public static readonly Guid EFI_DTB_TABLE_GUID = new(0xb1b621d5, 0xf19c, 0x41a5, 0x83, 0x0b, 0xd9, 0x15, 0x2c, 0x69, 0xaa, 0xe0);
    }
}
