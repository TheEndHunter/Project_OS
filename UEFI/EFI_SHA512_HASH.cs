﻿using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    public unsafe struct EFI_SHA512_HASH
    {
        [FieldOffset(0)]
        public fixed byte Data[64];
    }
}