using System.Runtime.InteropServices;

namespace System {
    [StructLayout(LayoutKind.Sequential)]
    public struct IntPtr {
        public static readonly nint Zero = 0;
        public IntPtr(nint value) {
            _value = value;
        }
        public unsafe IntPtr(void* value) {
#if BIT64
            _value = *(long*)(&value);
#else
            _value = *(int*)(&value);
#endif
        }
        public static unsafe explicit operator void*(IntPtr a) {
            return *(void**)&a._value;
        }
        public static unsafe explicit operator IntPtr(void* a) {
            return new IntPtr(a);
        }
        public static bool operator ==(IntPtr x, IntPtr y) {
            return x._value == y._value;
        }
        public static bool operator !=(IntPtr x, IntPtr y) {
            return x._value != y._value;
        }
#if BIT64
        private long _value;
        public static readonly int Size = 8;
        public IntPtr(long value) {
            _value = value;
        }
        public static explicit operator IntPtr(long a) {
            return new IntPtr(a);
        }
        public static explicit operator long(IntPtr a) {
            return a._value;
        }
#else
        private int _value;
        public static readonly int Size = 8;
        public IntPtr(int value)
        {
            _value = value;
        }
        public static explicit operator IntPtr(int a)
        {
            return new IntPtr(a);
        }
        public static explicit operator int(IntPtr a)
        {
            return a._value;
        }
#endif
    }
}
