using Efi;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public static unsafe class Program
{
    const string keyboardMessage = "Press Any Key To Continue...";
    const string GopInitialized = "GOP Initialization Successful...";

    public static readonly void* nullptr = (void*)0;
    public static void Main() { }

    private static EFI_GRAPHICS_OUTPUT_PROTOCOL* _GOP;
    private static EFI_GRAPHICS_OUTPUT_BLT_PIXEL _GraphicsColour;

    [System.Runtime.RuntimeExport("EfiMain")]
    public static unsafe UIntn EfiMain(EFI_HANDLE imageHandle, EFI_SYSTEM_TABLE* systemTable)
    {
        EfiConsole.Initialize(systemTable);
        Allocator.Initialize(systemTable);

        fixed (char* kbmsg = keyboardMessage)
        {
            EfiConsole.SetColor(EFI_TEXT_COLOR.BROWN, EFI_BACKGROUND_COLOR.GREEN);
            EfiConsole.ClearScreen();

            EfiConsole.WriteLine(kbmsg);
        }
        systemTable->ConIn->Reset();

        EFI_INPUT_KEY key;

        while (systemTable->ConIn->ReadKeyStroke(&key) == EFI_STATUS.NOT_READY) ;
        EfiConsole.Reset();
        EfiConsole.SetColor(EFI_TEXT_COLOR.WHITE, EFI_BACKGROUND_COLOR.BLACK);
        EfiConsole.ClearScreen();

        Guid g;

        Error.CheckEFIError(Allocator.Allocate(&g, EFI_MEMORY_TYPE.EfiLoaderCode));

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

        fixed (Guid* gid = &UEFI.GUIDs.PROTOCOL.EFI_GRAPHICS_OUTPUT_PROTOCOL)
        {
            EFI_STATUS s = systemTable->BootServices->LocateProtocol(&g, 0, (void**)_GOP);
            if (!Error.CheckEFIError(s))
            {
                fixed (char* msg = GopInitialized)
                {
                    EfiConsole.WriteLine(msg);
                }
            }

        }


        while (true) ;
    }
}