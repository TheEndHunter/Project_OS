using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public abstract class BitField<T> where T : unmanaged
    {
        protected T _field;
        public BitField(T value)
        {
            _field = value;
        }
        public BitField() : this(default)
        {
        }
        public bool this[int pos]
        {
            get => GetBit(pos);
            set => SetBit(pos, value);
        }
        protected abstract int BitLength { get; }
        protected abstract bool GetBit(int pos);
        protected abstract void SetBit(int pos, bool val);
    }
}
