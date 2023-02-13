namespace System
{
    public struct IntPtr
    {
        public IntPtr()
        {

        }
        public static readonly IntPtr Zero = 0;
        public static readonly int Size =
#if BIT64
            8;
#else
            4;
#endif
    }
}
