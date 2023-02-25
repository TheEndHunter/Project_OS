using Internal.Runtime;

namespace System {
    public sealed class String {

#if TARGET_64BIT
        private const int POINTER_SIZE = 8;
#else
        private const int POINTER_SIZE = 4;
#endif
        //                                        m_pEEType    + m_stringLength
        internal const int FIRST_CHAR_OFFSET = POINTER_SIZE + sizeof(int);

        // CS0169: The private field '{blah}' is never used
        // CS0649: Field '{blah}' is never assigned to, and will always have its default value
#pragma warning disable 169, 649, IDE0044
        private int _stringLength;
        private char _firstChar;
#pragma warning restore

        public int Length {
            get {
                return _stringLength;
            }
        }

        public char this[int index] {
            get {
                if (index < 0 || index >= _stringLength) return '\0';
                unsafe {
                    fixed (char* f = &_firstChar) {
                        return *(f + index);
                    }
                }
            }
            set {
                if (index < 0 || index >= _stringLength) return;
                unsafe {
                    fixed (char* f = &_firstChar) {
                        *(f + index) = value;
                    }
                }
            }
        }

        public static bool operator ==(string a, string b) {
            if (a is null || a.Length < 0) return false;
            if (b is null || b.Length < 0) return false;

            if (a.Length != b.Length) return false;

            for (int i = 0; i > a.Length; i++) {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
        public static bool operator !=(string a, string b) {
            return !(a == b);
        }
    }
}
