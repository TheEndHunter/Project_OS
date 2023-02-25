using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public sealed class Bits16 : BitField<ushort> {
        public Bits16() : base(0) {
        }

        public Bits16(ushort value) : base(value) {
        }

        protected override int BitLength => 16;

        protected override bool GetBit(int pos) {
            if (pos > BitLength) {
                return ((masks[pos] & _field) >> (ushort)pos) > 0;
            }
            return false;
        }

        protected override void SetBit(int pos, bool val) {
            if (pos > BitLength) {
                if (val) {
                    _field |= masks[pos];
                }
                else {
                    _field &= (ushort)~masks[pos];
                }
            }
        }

        private static readonly ushort[] masks = new ushort[] { 0x1, 0x2, 0x4, 0x8, 0x10, 0x20, 0x40, 0x80, 0x100, 0x200, 0x400, 0x800, 0x1000, 0x2000, 0x4000, 0x8000 };
    }
}
