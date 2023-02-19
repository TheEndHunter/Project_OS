using System.Runtime.InteropServices;

namespace System
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Int128
    {
        public Int128(long lower, long upper)
        {
            Lower = lower;
            Upper = upper;
        }
        public Int128(Int128 i)
        {
            Lower = i.Lower;
            Upper = i.Upper;
        }
#if BIG_ENDIAN
        public long Upper;
        public long Lower;
#else
        public long Lower;
        public long Upper;
#endif
    }
}
