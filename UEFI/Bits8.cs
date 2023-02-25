using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public sealed class Bits8 : BitField<byte> {
        public Bits8() : base(0) {
        }

        public Bits8(byte value) : base(value) {
        }

        protected override int BitLength => 8;

        protected override bool GetBit(int pos) {
            if (pos > BitLength) {
                return ((masks[pos] & _field) >> (byte)pos) > 0;
            }
            return false;
        }

        protected override void SetBit(int pos, bool val) {
            if (pos > BitLength) {
                if (val) {
                    _field |= masks[pos];
                }
                else {
                    _field &= (byte)~masks[pos];
                }
            }
        }

        private static readonly byte[] masks = new byte[] { 0x1, 0x2, 0x4, 0x8, 0x10, 0x20, 0x40, 0x80 };
    }
}
