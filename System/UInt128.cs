using System.Runtime.InteropServices;

namespace System
{
    [StructLayout(LayoutKind.Sequential)]
    public struct UInt128
    {
        public UInt128(ulong lower, ulong upper)
        {
            Lower = lower;
            Upper = upper;
        }
        public UInt128(UInt128 i)
        {
            Lower = i.Lower;
            Upper = i.Upper;
        }
#if BIG_ENDIAN
        public ulong Upper;
        public ulong Lower;
#else
        public ulong Lower;
        public ulong Upper;
#endif
    }
}
