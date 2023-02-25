using Efi;

using System;

namespace bootloader {

    public static unsafe class Program {

        public static uint GetStringLength(long num) {
            uint len = 1;
            if (num < 0) {
                len++;
            }
            ulong n = (ulong)num;
            while (n > 0) {
                len++;
                n /= 10;
            }
            return len;
        }
        public static uint GetStringLength(ulong num) {
            uint len = 1;
            ulong n = num;
            while (n > 0) {
                len++;
                n /= 10;
            }
            return len;
        }

        public static ulong GetStringLongLength(long num) {
            ulong len = 1;
            if (num < 0) {
                len++;
            }
            ulong n = (ulong)num;
            while (n > 0) {
                len++;
                n /= 10;
            }
            return len;
        }
        public static ulong GetStringLongLength(ulong num) {
            ulong len = 1;
            ulong n = num;
            while (n > 0) {
                len++;
                n /= 10;
            }
            return len;
        }

        public static bool ToString(char[] str, long num) {

            int len = 0;
            ulong rem, n;

            if (num < 0) {
                len++;

            }
            ulong a = (ulong)num;
            n = (ulong)num;
            while (n != 0) {
                len++;
                n /= 10;
            }

            if (str.Length < len + 1) return false;

            str[0] = '-';
            for (int i = 1; i < len; i++) {
                rem = a % 10;
                a = a / 10;
                str[len - (i + 1)] = (char)(rem + 48);
            }
            str[len] = '\0';

            return true;
        }
        public static bool ToString(char[] str, ulong num) {

            int len = 0;
            ulong rem, n;

            n = num;
            while (n != 0) {
                len++;
                n /= 10;
            }

            if (str.Length < len + 1) return false;

            for (int i = 0; i < len; i++) {
                rem = num % 10;
                num = num / 10;
                str[len - (i + 1)] = (char)(rem + 48);
            }
            str[len] = '\0';
            return true;
        }
        public static bool ToHex(char[] str, long num) {

            int len = 2;
            ulong rem, n;

            if (num < 0) {
                len++;
            }
            ulong a = (ulong)num;
            n = (ulong)(num);
            while (n != 0) {
                len++;
                n >>= 4;
            }

            if (str.Length < len + 1) return false;

            str[0] = '-';
            str[1] = '0';
            str[2] = 'x';
            for (int i = 3; i < len; i++) {
                rem = a % 16;
                a >>= 4;
                if (rem < 10)
                    str[len - (i + 1)] = (char)(rem + 48);
                else
                    str[len - (i + 1)] = (char)(rem + 55);
            }
            str[len] = '\0';
            return true;
        }
        public static bool ToHex(char[] str, ulong num) {

            int len = 2;
            ulong rem, n;

            n = num;
            while (n != 0) {
                len++;
                n /= 16;
            }

            if (str.Length < len + 1) return false;

            str[0] = '0';
            str[1] = 'x';
            for (int i = 2; i < len; i++) {
                rem = num % 16;
                num = num / 16;
                if (rem < 10)
                    str[len - (i + 1)] = (char)(rem + 48);
                else
                    str[len - (i + 1)] = (char)(rem + 55);
            }
            str[len] = '\0';
            return true;
        }

        public static bool ToString(char* str, ulong length, long num) {

            ulong len = 0;
            ulong rem, n;

            if (num < 0) {
                len++;

            }
            ulong a = (ulong)num;
            n = (ulong)num;
            while (n != 0) {
                len++;
                n /= 10;
            }

            if (length < len + 1) return false;

            str[0] = '-';
            for (ulong i = 1; i < len; i++) {
                rem = a % 10;
                a = a / 10;
                *(str + (len - (i + 1))) = (char)(rem + 48);
            }
            *(str + len) = '\0';

            return true;
        }
        public static bool ToString(char* str, ulong length, ulong num) {

            ulong len = 0;
            ulong rem, n;

            n = num;
            while (n != 0) {
                len++;
                n /= 10;
            }

            if (length < len + 1) return false;

            for (ulong i = 0; i < len; i++) {
                rem = num % 10;
                num = num / 10;
                *(str + (len - (i + 1))) = (char)(rem + 48);
            }
            *(str + len) = '\0';
            return true;
        }
        public static bool ToHex(char* str, ulong length, long num) {

            ulong len = 2;
            ulong rem, n;

            if (num < 0) {
                len++;
            }
            ulong a = (ulong)num;
            n = (ulong)(num);
            while (n != 0) {
                len++;
                n >>= 4;
            }

            if (length < len + 1) return false;

            str[0] = '-';
            str[1] = '0';
            str[2] = 'x';
            for (ulong i = 3; i < len; i++) {
                rem = a % 16;
                a >>= 4;
                if (rem < 10)
                    *(str + (len - (i + 1))) = (char)(rem + 48);
                else
                    *(str + (len - (i + 1))) = (char)(rem + 55);
            }
            *(str + len) = '\0';
            return true;
        }
        public static bool ToHex(char* str, ulong length, ulong num) {

            ulong len = 2;
            ulong rem, n;

            n = num;
            while (n != 0) {
                len++;
                n /= 16;
            }

            if (length < len + 1) return false;

            str[0] = '0';
            str[1] = 'x';
            for (ulong i = 2; i < len; i++) {
                rem = num % 16;
                num = num / 16;
                if (rem < 10)
                    *(str + (len - (i + 1))) = (char)(rem + 48);
                else
                    *(str + (len - (i + 1))) = (char)(rem + 55);
            }
            *(str + len) = '\0';
            return true;
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";
        public static string ToString(bool value) {
            return value ? TrueValue : FalseValue;
        }

        public static unsafe EFI_STATUS Free<T>(EFI_SYSTEM_TABLE* systemTable, void* addr) {
            return systemTable->BootServices->FreePool(addr);
        }

        public static unsafe EFI_STATUS AllocArray<T>(EFI_SYSTEM_TABLE* systemTable, ulong arraylength, T** location, EFI_MEMORY_TYPE memtype = EFI_MEMORY_TYPE.EfiLoaderData) {
            return systemTable->BootServices->AllocatePool(memtype, (ulong)sizeof(T) * arraylength, (void**)location);
        }

        public static unsafe EFI_STATUS Alloc<T>(EFI_SYSTEM_TABLE* systemTable, T** location, EFI_MEMORY_TYPE memtype = EFI_MEMORY_TYPE.EfiLoaderData) {
            return systemTable->BootServices->AllocatePool(memtype, (ulong)sizeof(T), (void**)location);
        }

        public const string msg_pressAnyKey = "Press Any Key To Continue...\r\n";
        public const string err_Alloc_Guid_Failed = "Unable To Allocate Guid\r\n";
        public const string err_Alloc_Page_Failed = "Unable To Allocate Page(s)\r\n";
        public const string err_Alloc_BLT_Failed = "Unable To Allocate BLT\r\n";
        public const string err_Find_Text_Mode_Failed = "Unable To Locate Valid TextMode\r\n";
        public const string msg_GopInitialized = "GOP Initialization Successful...\r\n";
        public const string err_GopNotInitialized = "GOP Initialization Unsuccessful...\r\n";
        public const ulong DefaultColor = 0x0F;
        public const ulong WarningColor = 0x0E;
        public const ulong ErrorColor = 0x1F;

        public static void Main() { }

        [System.Runtime.RuntimeExport("EfiMain")]
        public static unsafe UIntn EfiMain(EFI_HANDLE imageHandle, EFI_SYSTEM_TABLE* systemTable) {

            //Select highest resolution text mode available;
            int max = systemTable->ConOut->Mode->MaxMode;

            if (max > 0) {
                int modeSel = -1;
                ulong x = 0, y = 0;
                ulong vX = 0, vY = 0;
                int mode = 0;
                while (!(mode > max)) {
                    EFI_STATUS s = systemTable->ConOut->QueryMode(mode, &vX, &vY);
                    if (s == EFI_STATUS.SUCCESS) {
                        if (vX > x && vY > y) {
                            x = vX;
                            y = vY;
                            modeSel = mode;
                        }
                    }
                    else {
                        systemTable->ConOut->SetAttribute(WarningColor);
                        systemTable->ConOut->OutputString(s.ToCharPtr());
                        fixed (char* c = StringHelp.NewLine) {
                            systemTable->ConOut->OutputString(c);
                        }
                        systemTable->ConOut->SetAttribute(DefaultColor);
                    }
                    mode++;
                }
                if (modeSel == -1) {
                    systemTable->ConOut->Reset();
                    systemTable->ConOut->SetAttribute(ErrorColor);
                    systemTable->ConOut->ClearScreen();

                    fixed (char* msg = err_Find_Text_Mode_Failed) {
                        systemTable->ConOut->OutputString(msg);
                    }
                    while (true) ;
                }
                systemTable->ConOut->SetMode(modeSel);

            }
            systemTable->ConOut->SetAttribute(DefaultColor);
            systemTable->ConOut->ClearScreen();

            //Wait for user input
            EFI_INPUT_KEY key;
            fixed (char* kbmsg = msg_pressAnyKey) {
                systemTable->ConIn->Reset();
                systemTable->ConOut->OutputString(kbmsg);
                while (systemTable->ConIn->ReadKeyStroke(&key) == EFI_STATUS.NOT_READY) ;
                systemTable->ConOut->ClearScreen();
                systemTable->ConIn->Reset();
            }

            //Create Graphics Guid.
            Guid g = new() {
                a = 0x9042a9de,
                b = 0x23dc,
                c = 0x4a38,
                d = 0x96,
                e = 0xfb,
                f = 0x7a,
                g = 0xde,
                h = 0xd0,
                i = 0x80,
                j = 0x51,
                k = 0x6a,
            };

            //Set Graphics Mode
            EFI_GRAPHICS_OUTPUT_PROTOCOL _GOP = new();
            EFI_STATUS locateStat = systemTable->BootServices->LocateProtocol(&g, null, (void**)&_GOP);
            if (Error.CheckEFIError(locateStat)) {
                systemTable->ConOut->Reset();
                systemTable->ConOut->SetAttribute(ErrorColor);
                systemTable->ConOut->ClearScreen();

                fixed (char* msg = err_GopNotInitialized) {
                    systemTable->ConOut->OutputString(msg);
                    systemTable->ConOut->OutputString(locateStat.ToCharPtr());
                }
                while (true) ;
            }

            while (true) ;
        }
    }
}