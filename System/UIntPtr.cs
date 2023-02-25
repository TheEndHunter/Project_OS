using System.Runtime.InteropServices;

namespace System {
    [StructLayout(LayoutKind.Sequential)]
    public struct UIntPtr {
        public static readonly nuint Zero = 0;
        public UIntPtr(nuint value) {
            _value = value;
        }

        public unsafe UIntPtr(void* value) {
#if BIT64
            _value = *(ulong*)(&value);
#else
            _value = *(uint*)(&value);
#endif
        }

        public static unsafe explicit operator void*(UIntPtr a) {
            return *(void**)&a._value;
        }
        public static unsafe explicit operator UIntPtr(void* a) {
            return new UIntPtr(a);
        }
        public static bool operator ==(UIntPtr x, UIntPtr y) {
            return x._value == y._value;
        }
        public static bool operator !=(UIntPtr x, UIntPtr y) {
            return x._value != y._value;
        }
#if BIT64
        private ulong _value;
        public static readonly int Size = 8;
        public UIntPtr(ulong value) {
            _value = value;
        }
        public static explicit operator UIntPtr(ulong a) {
            return new UIntPtr(a);
        }
        public static explicit operator ulong(UIntPtr a) {
            return a._value;
        }
#else
       private uint _value;
        public static readonly int Size = 8;
        public UIntPtr(uint value)
        {
            _value = value;
        }
        public static explicit operator UIntPtr(uint a)
        {
            return new UIntPtr(a);
        }
        public static explicit operator uint(UIntPtr a)
        {
            return a._value;
        }
#endif
    }
}
