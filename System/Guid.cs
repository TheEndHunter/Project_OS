using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct Guid
    {
        private uint _a;   // Do not rename (binary serialization)
        private ushort _b; // Do not rename (binary serialization)
        private ushort _c; // Do not rename (binary serialization)
        private byte _d;  // Do not rename (binary serialization)
        private byte _e;  // Do not rename (binary serialization)
        private byte _f;  // Do not rename (binary serialization)
        private byte _g;  // Do not rename (binary serialization)
        private byte _h;  // Do not rename (binary serialization)
        private byte _i;  // Do not rename (binary serialization)
        private byte _j;  // Do not rename (binary serialization)
        private byte _k;  // Do not rename (binary serialization)

        public uint a { get => _a; internal set { _a = value; } }
        public ushort b { get => _b; internal set { _b = value; } }
        public ushort c { get => _c; internal set { _c = value; } }
        public byte d { get => _d; internal set { _d = value; } }
        public byte e { get => _e; internal set { _e = value; } }
        public byte f { get => _f; internal set { _f = value; } }
        public byte g { get => _g; internal set { _g = value; } }
        public byte h { get => _h; internal set { _h = value; } }
        public byte i { get => _i; internal set { _i = value; } }
        public byte j { get => _j; internal set { _j = value; } }
        public byte k { get => _k; internal set { _k = value; } }

        [Intrinsic]
        public static readonly Guid Empty;
        public Guid(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
            _e = e;
            _f = f;
            _g = g;
            _h = h;
            _i = i;
            _j = j;
            _k = k;
        }

        // Creates a new GUID initialized to the _value represented by the arguments.
        public Guid(int a, short b, short c, byte[] d)
        {
            if (d is null || d.Length != 8)
            {
                this = default;
                return;
            }

            _a = (uint)a;
            _b = (ushort)b;
            _c = (ushort)c;
            _k = d[7]; // hoist bounds checks
            _d = d[0];
            _e = d[1];
            _f = d[2];
            _g = d[3];
            _h = d[4];
            _i = d[5];
            _j = d[6];
        }

        // Creates a new GUID initialized to the _value represented by the
        // arguments.  The bytes are specified like this to avoid endianness issues.
        public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
        {
            _a = (uint)a;
            _b = (ushort)b;
            _c = (ushort)c;
            _d = d;
            _e = e;
            _f = f;
            _g = g;
            _h = h;
            _i = i;
            _j = j;
            _k = k;
        }
    }
}
