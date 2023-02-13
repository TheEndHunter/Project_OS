namespace System
{
    public struct UIntPtr
    {
        public UIntPtr()
        {
        }
        public static readonly UIntPtr Zero = 0;
        public static readonly int Size =
#if BIT64
                8;
#else
                4;
#endif
    }
}
