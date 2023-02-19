using Efi;

using System;
using System.Runtime;

public static unsafe class Program
{
    public static bool CheckError(EFI_STATUS s, char* errMsg)
    {
        bool a = (s != EFI_STATUS.SUCCESS);
        if (a)
        {
            _sysTable->ConOut->SetAttribute(EFI_TEXT_COLOR.RED, EFI_BACKGROUND_COLOR.BLACK);
            _sysTable->ConOut->ClearScreen();
            _sysTable->ConOut->OutputString(errMsg);
        }
        return a;
    }

    const string keyboardMessage = "Press Any Key To Continue...";
    const string msg_GOP_INITIALIZED = "GOP Initialized...";
    const string err_ALLOC_FAILED = "Allocation Failed...";
    const string err_GOP_NOT_INITIALIZED = "GOP Not Initialized...";
    public static readonly void* nullptr = (void*)0;
    public static void Main() { }

    private static EFI_SYSTEM_TABLE* _sysTable;
    private static EFI_GRAPHICS_OUTPUT_PROTOCOL* _GOP;
    private static EFI_GRAPHICS_OUTPUT_BLT_PIXEL _GraphicsColour;

    [System.Runtime.RuntimeExport("EfiMain")]
    public static unsafe UIntn EfiMain(EFI_HANDLE imageHandle, EFI_SYSTEM_TABLE* systemTable)
    {
        _sysTable = systemTable;

        fixed (char* kbmsg = keyboardMessage)
        {
            systemTable->ConOut->SetAttribute(EFI_TEXT_COLOR.BROWN, EFI_BACKGROUND_COLOR.GREEN);
            systemTable->ConOut->ClearScreen();

            systemTable->ConOut->OutputString(kbmsg);

            systemTable->ConIn->Reset();

            EFI_INPUT_KEY key;

            while (systemTable->ConIn->ReadKeyStroke(&key) == EFI_STATUS.NOT_READY) ;
            systemTable->ConOut->Reset();
            systemTable->ConOut->SetAttribute(EFI_TEXT_COLOR.WHITE, EFI_BACKGROUND_COLOR.BLACK);
            systemTable->ConOut->ClearScreen();


            fixed (Guid* gid = &UEFI.GUIDs.PROTOCOL.EFI_GRAPHICS_OUTPUT_PROTOCOL)
            {
                EFI_STATUS s = systemTable->BootServices->LocateProtocol(gid, nullptr, (void**)_GOP);
                fixed (char* err = err_GOP_NOT_INITIALIZED)
                {
                    if (!CheckError(s, err))
                    {
                        fixed (char* msg = msg_GOP_INITIALIZED)
                        {
                            systemTable->ConOut->OutputString(msg);
                        }
                    }
                }

            }

        }
        while (true) ;
    }
}