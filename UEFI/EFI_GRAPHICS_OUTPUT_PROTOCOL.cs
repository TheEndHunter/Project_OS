using System;
using System.Runtime.InteropServices;

namespace Efi
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct EFI_GRAPHICS_OUTPUT_PROTOCOL
    {
        private readonly unsafe delegate* unmanaged<EFI_GRAPHICS_OUTPUT_PROTOCOL*, uint, UIntn*, EFI_GRAPHICS_OUTPUT_MODE_INFORMATION**, EFI_STATUS> _QueryMode;
        private readonly unsafe delegate* unmanaged<EFI_GRAPHICS_OUTPUT_PROTOCOL*, uint, EFI_STATUS> _SetMode;
        private readonly unsafe delegate* unmanaged<EFI_GRAPHICS_OUTPUT_PROTOCOL*, EFI_GRAPHICS_OUTPUT_BLT_PIXEL*, EFI_GRAPHICS_OUTPUT_BLT_OPERATION, UIntn, UIntn, UIntn, UIntn, UIntn, UIntn, UIntn, EFI_STATUS> _Blt;
        public readonly EFI_GRAPHICS_OUTPUT_PROTOCOL_MODE* Mode;
        public EFI_STATUS QueryMode(uint modeNumber, UIntn* sizeOfInfo, EFI_GRAPHICS_OUTPUT_MODE_INFORMATION** info)
        {
            fixed (EFI_GRAPHICS_OUTPUT_PROTOCOL* s = &this)
            {
                return _QueryMode(s, modeNumber, sizeOfInfo, info);
            }
        }

        public EFI_STATUS SetMode(uint modeNumber)
        {
            fixed (EFI_GRAPHICS_OUTPUT_PROTOCOL* s = &this)
            {
                return _SetMode(s, modeNumber);
            }
        }

        public EFI_STATUS Blt(EFI_GRAPHICS_OUTPUT_BLT_PIXEL* bltBuffer, EFI_GRAPHICS_OUTPUT_BLT_OPERATION bltOp, UIntn srcX, UIntn srcY, UIntn destX, UIntn destY, UIntn width, UIntn height, UIntn delta)
        {
            fixed (EFI_GRAPHICS_OUTPUT_PROTOCOL* s = &this)
            {
                return _Blt(s, bltBuffer, bltOp, srcX, srcY, destX, destY, width, height, delta);
            }
        }

    }
}
