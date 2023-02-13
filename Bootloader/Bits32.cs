using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public sealed class Bits32 : BitField<uint>
    {
        public Bits32() : base(0)
        {
        }

        public Bits32(uint value) : base(value)
        {
        }

        protected override int BitLength => 16;

        protected override bool GetBit(int pos)
        {
            if (pos > BitLength)
            {
                return ((_field & masks[pos]) >> pos) > 0;
            }
            return false;
        }

        protected override void SetBit(int pos, bool val)
        {
            if (pos > BitLength)
            {
                if (val)
                {
                    _field |= masks[pos];
                }
                else
                {
                    _field &= ~masks[pos];
                }
            }
        }

        private static readonly uint[] masks = new uint[] { 0x1, 0x2, 0x4, 0x8, 0x10, 0x20, 0x40, 0x80, 0x100, 0x200, 0x400, 0x800, 0x1000, 0x2000, 0x4000, 0x8000,
        0x10000, 0x20000, 0x40000, 0x80000, 0x100000, 0x200000, 0x400000, 0x800000, 0x1000000, 0x2000000, 0x4000000, 0x8000000, 0x10000000, 0x20000000, 0x40000000, 0x80000000};
    }
}
