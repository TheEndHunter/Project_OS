using System;
using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL
    {
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, bool, EFI_STATUS> _Reset;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, char*, EFI_STATUS> _OutputString;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, char*, EFI_STATUS> _TestString;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, UIntn, UIntn*, UIntn*, EFI_STATUS> _QueryMode;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, UIntn, EFI_STATUS> _SetMode;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, UIntn, EFI_STATUS> _SetAttribute;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, EFI_STATUS> _ClearScreen;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, UIntn, UIntn, EFI_STATUS> _SetCursorPosition;
        private readonly unsafe delegate* unmanaged<EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL*, bool, EFI_STATUS> _EnableCursor;
        private readonly SIMPLE_TEXT_OUTPUT_MODE* Mode;

        public unsafe EFI_STATUS Reset(bool verify)
        {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this)
            {
                return _Reset(s, verify);
            }
        }
        public unsafe EFI_STATUS OutputString(string msg)
        {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this)
            {
                fixed (char* c = msg)
                {
                    return _OutputString(s, c);
                }
            }
        }
        public unsafe EFI_STATUS OutputString(char* msg)
        {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this)
            {
                return _OutputString(s, msg);
            }
        }
        public unsafe EFI_STATUS TestString(string msg)
        {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this)
            {
                fixed (char* c = msg)
                {
                    return _TestString(s, c);
                }
            }
        }
        public unsafe EFI_STATUS TestString(char* msg)
        {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this)
            {
                return _TestString(s, msg);
            }
        }
        public unsafe EFI_STATUS QueryMode(UIntn a, UIntn* b, UIntn* c)
        {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this)
            {
                return _QueryMode(s, a, b, c);
            }
        }

        public unsafe EFI_STATUS SetMode(UIntn a)
        {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this)
            {
                return _SetMode(s, a);
            }
        }
        public unsafe EFI_STATUS SetAttribute(EFI_TEXT_COLOR text, EFI_BACKGROUND_COLOR bg)
        {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this)
            {
                return _SetAttribute(s, ((ulong)bg | (ulong)text));
            }
        }
        public unsafe EFI_STATUS SetAttribute(UIntn a)
        {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this)
            {
                return _SetAttribute(s, a);
            }
        }
        public unsafe EFI_STATUS ClearScreen()
        {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this)
            {
                return _ClearScreen(s);
            }
        }

        public unsafe EFI_STATUS SetCursorPosition(UIntn x, UIntn y)
        {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this)
            {
                return _SetCursorPosition(s, x, y);
            }
        }
        public unsafe EFI_STATUS EnableCursor(bool a)
        {
            fixed (EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* s = &this)
            {
                return _EnableCursor(s, a);
            }
        }
    };
}
