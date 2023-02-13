using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    public readonly unsafe struct EFI_UNINSTALL_MULTIPLE_PROTOCOL
    {
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_STATUS> _1; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _2; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _3; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _4; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _5; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _6; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _7; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _8; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _9; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _10; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _11; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _12; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _13; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _14; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _15; // EFI 1.1+
        [FieldOffset(0)]
        private readonly unsafe delegate* unmanaged<EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_HANDLE*, EFI_STATUS> _16; // EFI 1.1+

        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg) => _1(arg); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2) => _2(arg, arg2); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3) => _3(arg, arg2, arg3); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4) => _4(arg, arg2, arg3, arg4); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5) => _5(arg, arg2, arg3, arg4, arg5); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6) => _6(arg, arg2, arg3, arg4, arg5, arg6); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7) => _7(arg, arg2, arg3, arg4, arg5, arg6, arg7); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8) => _8(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9) => _9(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10) => _10(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11) => _11(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11, EFI_HANDLE* arg12) => _12(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11, EFI_HANDLE* arg12, EFI_HANDLE* arg13) => _13(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11, EFI_HANDLE* arg12, EFI_HANDLE* arg13, EFI_HANDLE* arg14) => _14(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11, EFI_HANDLE* arg12, EFI_HANDLE* arg13, EFI_HANDLE* arg14, EFI_HANDLE* arg15) => _15(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15); // EFI 1.1+
        public unsafe EFI_STATUS Invoke(EFI_HANDLE* arg, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11, EFI_HANDLE* arg12, EFI_HANDLE* arg13, EFI_HANDLE* arg14, EFI_HANDLE* arg15, EFI_HANDLE* arg16) => _16(arg, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16); // EFI 1.1+


    }
}
