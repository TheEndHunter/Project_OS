using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
    [EagerStaticClassConstruction]
    [StructLayout(LayoutKind.Sequential)]
    public partial class String
    {
#if TARGET_64BIT
        private const int POINTER_SIZE = 8;
#else
        private const int POINTER_SIZE = 4;
#endif
        //                                        m_pEEType    + m_stringLength
        internal const int FIRST_CHAR_OFFSET = POINTER_SIZE + sizeof(int);

        // CS0169: The private field '{blah}' is never used
        // CS0649: Field '{blah}' is never assigned to, and will always have its default value
#pragma warning disable 169, 649
        private int _stringLength;
        private char _firstChar;

#pragma warning restore


        public int Length
        {
            get
            {
                return _stringLength;
            }
        }

        [Intrinsic]
        public static readonly string Empty = "";
    }

    public partial class String
    {
        public ref readonly char GetPinnableReference() => ref _firstChar;
        public char this[int index]
        {
            get
            {
                if (index < 0 || index > _stringLength) return '-';

                unsafe
                {
                    fixed (char* c = &_firstChar)
                    {
                        return *(c + index);
                    }
                }
            }
        }

        internal ref char GetRawStringData() => ref _firstChar;
        internal ref ushort GetRawStringDataAsUInt16() => ref Unsafe.As<char, ushort>(ref _firstChar);

        public static bool operator ==(string? a, string? b)
        {
            if (a == null || b == null) return false;
            if (a._stringLength != b._stringLength) return false;

            for (int i = 0; i < a._stringLength; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }

        public static bool operator !=(string? a, string? b)
        {
            return !(a == b);
        }
    }
}
