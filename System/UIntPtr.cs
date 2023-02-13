namespace System
{
    public struct UIntPtr
    {
        public static readonly nuint Zero = 0;
#if BIT64
        public static readonly int Size = 8;
#else
        public static readonly int Size = 4;
#endif
    }
}
