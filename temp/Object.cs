using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
    public class Object
    {
#pragma warning disable 169
        // The layout of object is a contract with the compiler.
        private IntPtr m_pMethodTable;
#pragma warning restore 169

        [Intrinsic]
        public virtual bool Equals(object o)
        {
            if (this == null) return false;
            if (o == null) return false;

            return GetRawData() == o.GetRawData();
        }

        public static bool Equals(object a, object b)
        {
            return a.Equals(b);
        }

        public static bool operator ==(object a, object b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(object a, object b)
        {
            return !a.Equals(b);
        }

        [StructLayout(LayoutKind.Sequential)]
        private class RawData
        {
            public byte Data;
        }

        [Intrinsic]
        public virtual int GetHashCode()
        {
            return 0;
        }

        /// <summary>
        /// Return beginning of all data (excluding ObjHeader and MethodTable*) within this object.
        /// Note that for strings/arrays this would include the Length as well.
        /// </summary>
        internal ref byte GetRawData()
        {
            return ref Unsafe.As<RawData>(this).Data;
        }
    }
}
