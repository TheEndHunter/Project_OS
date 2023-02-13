using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
    public abstract class Array
    {
        public readonly int _Length;
        public int Length => (int)Unsafe.As<RawArrayData>(this).Length;
        public nuint NativeLength => Unsafe.As<RawArrayData>(this).Length;

        private static class EmptyArray<T>
        {
#pragma warning disable CA1825 // this is the implementation of Array.Empty<T>()
            internal static readonly T[] Value = new T[0];
#pragma warning restore CA1825
        }

        public static T[] Empty<T>()
        {
            return EmptyArray<T>.Value;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal class RawArrayData
    {
        public readonly uint Length; // Array._numComponents padded to IntPtr
#if BIT64
        public uint Padding;
#endif
        public readonly byte Data;
    }
}
