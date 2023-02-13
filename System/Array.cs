namespace System
{
    public abstract class Array
    {
        private readonly int _length;


        public int Length => _length;
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

    class Array<T> : Array { }
}
