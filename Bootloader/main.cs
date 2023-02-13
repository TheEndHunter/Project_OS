using Efi;

using System;
using System.Runtime;

public unsafe class Program
{
    public static void Main() { }

    [System.Runtime.RuntimeExport("EfiMain")]
    public static unsafe long EfiMain(EFI_HANDLE imageHandle, EFI_SYSTEM_TABLE* systemTable)
    {
        string hello = "Hello world!";
        string Goodbye = "Good Bye world!";
        fixed (char* hptr = hello)
        {
            fixed (char* gptr = Goodbye)
            {
                systemTable->ConOut->SetAttribute(EFI_TEXT_COLOR.BLACK, EFI_BACKGROUND_COLOR.CYAN);
                systemTable->ConOut->ClearScreen();
                systemTable->ConOut->OutputString(hptr);
                systemTable->ConOut->OutputString(Environment.NewLine);
                systemTable->ConOut->OutputString(gptr);
            }
        }
        while (true) ;
    }
}