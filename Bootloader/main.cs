using Efi;

using System;

namespace bootloader {
    public static unsafe class Program {
        public static unsafe EFI_STATUS Free<T>(EFI_SYSTEM_TABLE* systemTable, void* addr) {
            return systemTable->BootServices->FreePool(addr);
        }

        public static unsafe EFI_STATUS Alloc<T>(EFI_SYSTEM_TABLE* systemTable, T** location, EFI_MEMORY_TYPE memtype = EFI_MEMORY_TYPE.EfiLoaderData) {
            return systemTable->BootServices->AllocatePool(memtype, (ulong)sizeof(T), (void**)location);
        }

        public const string msg_pressAnyKey = "Press Any Key To Continue...\r\n";
        public const string msg_Alloc_Guid_Failed = "Unable To Allocate Guid\r\n";
        public const string msg_Alloc_BLT_Failed = "Unable To Allocate BLT\r\n";
        public const string msg_GopInitialized = "GOP Initialization Successful...\r\n";
        public const string msg_GopNotInitialized = "GOP Initialization Unsuccessful...\r\n";
        public const ulong DefaultColor = 0x0F;
        public const ulong ErrorColor = 0x1F;

        public static void Main() { }

        [System.Runtime.RuntimeExport("EfiMain")]
        public static unsafe UIntn EfiMain(EFI_HANDLE imageHandle, EFI_SYSTEM_TABLE* systemTable) {
            systemTable->ConOut->SetAttribute(DefaultColor);
            systemTable->ConOut->ClearScreen();

            EFI_INPUT_KEY key;
            fixed (char* kbmsg = msg_pressAnyKey) {
                systemTable->ConOut->OutputString(kbmsg);
                while (systemTable->ConIn->ReadKeyStroke(&key) == EFI_STATUS.NOT_READY) ;
                systemTable->ConOut->ClearScreen();
                systemTable->ConIn->Reset();
            }

            Guid g = new();

            EFI_STATUS guidStat = Alloc<Guid>(systemTable, (Guid**)&g);

            if (Error.CheckEFIError(guidStat)) {
                systemTable->ConOut->Reset();
                systemTable->ConOut->SetAttribute(ErrorColor);
                systemTable->ConOut->ClearScreen();
                fixed (char* c = msg_Alloc_Guid_Failed) {
                    systemTable->ConOut->OutputString(c);
                }
                systemTable->ConOut->OutputString(guidStat.ToCharPtr());
                while (true) ;
            }

            g.a = 0x9042a9de;
            g.b = 0x23dc;
            g.c = 0x4a38;
            g.d = 0x96;
            g.e = 0xfb;
            g.f = 0x7a;
            g.g = 0xde;
            g.h = 0xd0;
            g.i = 0x80;
            g.j = 0x51;
            g.k = 0x6a;

            EFI_GRAPHICS_OUTPUT_PROTOCOL _GOP = new();
            EFI_STATUS locateStat = systemTable->BootServices->LocateProtocol(&g, null, (void**)&_GOP);
            if (Error.CheckEFIError(locateStat)) {
                systemTable->ConOut->Reset();
                systemTable->ConOut->SetAttribute(ErrorColor);
                systemTable->ConOut->ClearScreen();

                fixed (char* msg = msg_GopNotInitialized) {
                    systemTable->ConOut->OutputString(msg);
                    systemTable->ConOut->OutputString(locateStat.ToCharPtr());
                }
                while (true) ;
            }

            EFI_GRAPHICS_OUTPUT_BLT_PIXEL _GraphicsColour = new();
            EFI_STATUS BltStat = Alloc<EFI_GRAPHICS_OUTPUT_BLT_PIXEL>(systemTable, (EFI_GRAPHICS_OUTPUT_BLT_PIXEL**)&_GraphicsColour);

            if (Error.CheckEFIError(BltStat)) {
                systemTable->ConOut->Reset();
                systemTable->ConOut->SetAttribute(ErrorColor);
                systemTable->ConOut->ClearScreen();
                fixed (char* c = msg_Alloc_BLT_Failed) {
                    systemTable->ConOut->OutputString(c);
                }
                systemTable->ConOut->OutputString(BltStat.ToCharPtr());
                while (true) ;
            }

            fixed (char* kbmsg = msg_GopInitialized) {
                systemTable->ConOut->OutputString(kbmsg);
            }

            while (true) ;
        }
    }
}