using Efi;

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

public static class EfiConsole
{
    public static unsafe void Initialize(EFI_SYSTEM_TABLE* sysTable)
    {
        stdOut = sysTable->ConOut;
        stdErr = sysTable->StdErr;
    }

    public static void ClearScreen()
    {
        unsafe
        {
            stdOut->ClearScreen();
        }
    }
    public static void Reset()
    {
        unsafe
        {
            stdOut->Reset();
        }
    }
    public static readonly EFI_TEXT_COLOR DefaultTextColor = EFI_TEXT_COLOR.WHITE;
    public static readonly EFI_BACKGROUND_COLOR DefaultBackgroundColor = EFI_BACKGROUND_COLOR.BLACK;

    public static EFI_TEXT_COLOR CurrentTextColor = DefaultTextColor;
    public static EFI_BACKGROUND_COLOR CurrentBackgroundColor = DefaultBackgroundColor;

    public static EFI_TEXT_COLOR LastTextColor = DefaultTextColor;
    public static EFI_BACKGROUND_COLOR LastBackgroundColor = DefaultBackgroundColor;

    public static void SetColor(EFI_TEXT_COLOR text, EFI_BACKGROUND_COLOR bg)
    {
        unsafe
        {
            if (stdOut->SetAttribute(text, bg) == EFI_STATUS.SUCCESS)
            {
                CurrentTextColor = text;
                CurrentBackgroundColor = bg;
            }
        }
    }
    public static void RestoreLastColor()
    {
        SetColor(LastTextColor, LastBackgroundColor);
    }
    public static void RestoreDefaultColor()
    {
        SetColor(DefaultTextColor, DefaultBackgroundColor);
    }

    private static unsafe EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* stdOut;
    private static unsafe EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* stdErr;
    public static unsafe void Write(char* msg)
    {
        stdOut->OutputString(msg);
    }
    public static unsafe void Write(string msg)
    {
        stdOut->OutputString(msg);
    }
    public static unsafe void WriteLine(char* msg)
    {
        stdOut->OutputString(msg);
        stdOut->OutputString(Environment.NewLine);
    }
    public static unsafe void WriteLine(string msg)
    {
        stdOut->OutputString(msg);
        stdOut->OutputString(Environment.NewLine);
    }

    public static class Error
    {
        public static readonly EFI_TEXT_COLOR DefaultTextColor = EFI_TEXT_COLOR.BLACK;
        public static readonly EFI_BACKGROUND_COLOR DefaultBackgroundColor = EFI_BACKGROUND_COLOR.BLUE;

        public static EFI_TEXT_COLOR CurrentTextColor = DefaultTextColor;
        public static EFI_BACKGROUND_COLOR CurrentBackgroundColor = DefaultBackgroundColor;

        public static EFI_TEXT_COLOR LastTextColor = DefaultTextColor;
        public static EFI_BACKGROUND_COLOR LastBackgroundColor = DefaultBackgroundColor;

        public static void ClearScreen()
        {
            unsafe
            {
                stdErr->ClearScreen();
            }
        }
        public static void Reset()
        {
            unsafe
            {
                stdErr->Reset();
            }
        }

        public static void SetColor(EFI_TEXT_COLOR text, EFI_BACKGROUND_COLOR bg)
        {
            unsafe
            {
                if (stdErr->SetAttribute(text, bg) == EFI_STATUS.SUCCESS)
                {
                    LastTextColor = CurrentTextColor;
                    CurrentTextColor = text;
                    LastBackgroundColor = CurrentBackgroundColor;
                    CurrentBackgroundColor = bg;
                }
            }
        }
        public static void RestoreLastColor()
        {
            SetColor(LastTextColor, LastBackgroundColor);
        }
        public static void RestoreDefaultColor()
        {
            SetColor(DefaultTextColor, DefaultBackgroundColor);
        }
        public static unsafe void Write(char* msg)
        {
            stdErr->OutputString(msg);
            stdErr->OutputString(Environment.NewLine);
        }
        public static unsafe void Write(string msg)
        {
            stdErr->OutputString(msg);
            stdErr->OutputString(Environment.NewLine);
        }
        public static unsafe void WriteLine(char* msg)
        {
            stdErr->OutputString(msg);
            stdErr->OutputString(Environment.NewLine);
        }
        public static unsafe void WriteLine(string msg)
        {
            stdErr->OutputString(msg);
            stdErr->OutputString(Environment.NewLine);
        }
    }
}

public static unsafe class Error
{
    const string LOAD_ERROR = nameof(LOAD_ERROR);
    public static void WriteError(char* errMsg, [CallerArgumentExpression(nameof(errMsg))] string argExp = "", [CallerLineNumber] uint ln = 0, [CallerMemberName] string mn = "", [CallerFilePath] string fp = "")
    {
        EfiConsole.Error.RestoreDefaultColor();
        EfiConsole.Error.WriteLine(errMsg);
        EfiConsole.Error.Write(mn);
        EfiConsole.Error.Write(" ");
        EfiConsole.Error.Write(fp);
        EfiConsole.Error.Write(Environment.NewLine);
        EfiConsole.Error.RestoreLastColor();
    }
    public static void WriteError(string errMsg, [CallerArgumentExpression(nameof(errMsg))] string argExp = "", [CallerLineNumber] uint ln = 0, [CallerMemberName] string mn = "", [CallerFilePath] string fp = "")
    {
        EfiConsole.Error.RestoreDefaultColor();
        EfiConsole.Error.WriteLine(errMsg);
        EfiConsole.Error.Write(mn);
        EfiConsole.Error.Write(" ");
        EfiConsole.Error.Write(fp);
        EfiConsole.Error.Write(Environment.NewLine);
        EfiConsole.Error.RestoreLastColor();
    }

    [DoesNotReturn]
    public static void ThrowError(string errMsg, [CallerArgumentExpression(nameof(errMsg))] string argExp = "", [CallerLineNumber] uint ln = 0, [CallerMemberName] string mn = "", [CallerFilePath] string fp = "")
    {
        EfiConsole.Error.RestoreDefaultColor();
        EfiConsole.Error.ClearScreen();
        EfiConsole.Error.WriteLine(errMsg);
        EfiConsole.Error.Write(mn);
        EfiConsole.Error.Write(" ");
        EfiConsole.Error.Write(fp);
        EfiConsole.Error.Write(Environment.NewLine);
        while (true) ;
    }

    [DoesNotReturn]
    private static void ThrowError(char* errMsg, [CallerArgumentExpression(nameof(errMsg))] string argExp = "", [CallerLineNumber] uint ln = 0, [CallerMemberName] string mn = "", [CallerFilePath] string fp = "")
    {
        EfiConsole.Error.RestoreDefaultColor();
        EfiConsole.Error.ClearScreen();
        EfiConsole.Error.WriteLine(errMsg);
        EfiConsole.Error.Write(mn);
        EfiConsole.Error.Write(" ");
        EfiConsole.Error.Write(fp);
        EfiConsole.Error.Write(Environment.NewLine);
        while (true) ;
    }

    public const string err_LoadError = "Load Error";
    const string err_InvalidParameter = "Invalid Parameter";
    const string err_Unsupported = "Unsupported";
    const string err_BadBufferSize = "Bad Buffer Size";
    const string err_BufferTooSmall = "Buffer To Small";
    const string err_NotReady = "Not Ready";
    const string err_DeviceError = "Device Error";
    const string err_WriteProtected = "Write Protected";
    const string err_OutOfResources = "Out Of Resources";
    const string err_VolumeCorrupt = "Volume Corrupted";
    const string err_VolumeFull = "Volume Full";
    const string err_NoMedia = "No Media";
    const string err_MediaChanged = "Media Changed";
    const string err_NotFound = "Not Found";
    const string err_AccessDenied = "Access Denied";
    const string err_NoResponse = "No Response";
    const string err_NoMapping = "No Mapping";
    const string err_TimeOut = "Time Out";
    const string err_NotStarted = "Not Started";
    const string err_AlreadyStarted = "Already Started";
    const string err_Aborted = "Aborted";
    const string err_ICMPError = "ICMP Error";
    const string err_TFTPError = "TFTP Error";
    const string err_ProtocolError = "Protocol Error";
    const string err_IncompatibleVersion = "Incompatible Version";
    const string err_SecurityVoilation = "Security Violation";
    const string err_CrcError = "Crc Error";
    const string err_EndOfMedia = "End Of Media";
    const string err_EndOfFile = "EndOf File";
    const string err_InvalidLanguage = "Invalid Language";
    const string err_CompromisedData = "Compromised Data";
    const string err_IPAddressConflict = "IP Address Conflict";
    const string err_HTTPError = "HTTP Error";
    const string wrn_UnknownGlyph = "Warn Unknown Glyph";
    const string wrn_DeleteFailure = "Warn Delete Failure";
    const string wrn_WriteFailure = "Warn Write Failure";
    const string wrn_BufferTooSmall = "Warn Buffer Too Small";
    const string wrn_StaleData = "Warn Stale Data";
    const string wrn_FileSystem = "Warn File System";
    const string wrn_ResetRequired = "Warn Reset Required";
    public static bool CheckEFIError(EFI_STATUS s, [CallerArgumentExpression(nameof(s))] string argExp = "", [CallerLineNumber] uint ln = 0, [CallerMemberName] string mn = "", [CallerFilePath] string fp = "")
    {
        switch (s)
        {
            case EFI_STATUS.SUCCESS: break;
            case EFI_STATUS.LOAD_ERROR:
                ThrowError(err_LoadError, argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.INVALID_PARAMETER:
                ThrowError(err_InvalidParameter, argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.UNSUPPORTED:
                ThrowError(err_Unsupported, argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.BAD_BUFFER_SIZE:
                ThrowError(err_BadBufferSize, argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.BUFFER_TOO_SMALL:
                ThrowError("Buffer To Small", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.NOT_READY:
                ThrowError("Not Ready", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.DEVICE_ERROR:
                ThrowError("Device Error", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.WRITE_PROTECTED:
                ThrowError("Write Protected", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.OUT_OF_RESOURCES:
                ThrowError("Out Of Resources", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.VOLUME_CORRUPTED:
                ThrowError("Volume Corrupted", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.VOLUME_FULL:
                ThrowError("Volume Full", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.NO_MEDIA:
                ThrowError("No Media", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.MEDIA_CHANGED:
                ThrowError("Media Changed", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.NOT_FOUND:
                ThrowError("Not Found", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.ACCESS_DENIED:
                ThrowError("Access Denied", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.NO_RESPONSE:
                ThrowError("No Response", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.NO_MAPPING:
                ThrowError("No Mapping", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.TIMEOUT:
                ThrowError("Time Out", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.NOT_STARTED:
                ThrowError("Not Started", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.ALREADY_START:
                ThrowError("Already Started", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.ABORTED:
                ThrowError("Aborted", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.ICMP_ERROR:
                ThrowError("ICMP Error", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.TFTP_ERROR:
                ThrowError("TFTP Error", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.PROTOCOL_ERROR:
                ThrowError("Protocol Error", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.INCOMPATIBLE_VERSION:
                ThrowError("Incompatible Version", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.SECURITY_VIOLATION:
                ThrowError("Security Violation", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.CRC_ERROR:
                ThrowError("Crc Error", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.END_OF_MEDIA:
                ThrowError("End Of Media", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.END_OF_FILE:
                ThrowError("EndOf File", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.INVALID_LANGUAGE:
                ThrowError("Invalid Language", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.COMPROMISED_DATA:
                ThrowError("Compromised Data", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.IP_ADDRESS_CONFLICT:
                ThrowError("Ip Address Conflict", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.HTTP_ERROR:
                ThrowError("HTTP Error", argExp, ln, mn, fp);
                return true;
            case EFI_STATUS.WARN_UNKNOWN_GLYPH:
                ThrowError("Warn Unknown Glyph", argExp, ln, mn, fp);
                break;
            case EFI_STATUS.WARN_DELETE_FAILURE:
                ThrowError("Warn Delete Failure", argExp, ln, mn, fp);
                break;
            case EFI_STATUS.WARN_WRITE_FAILURE:
                ThrowError("Warn Write Failure", argExp, ln, mn, fp);
                break;
            case EFI_STATUS.WARN_BUFFER_TOO_SMALL:
                ThrowError("Warn Buffer Too Small", argExp, ln, mn, fp);
                break;
            case EFI_STATUS.WARN_STALE_DATA:
                ThrowError("Warn Stale Data", argExp, ln, mn, fp);
                break;
            case EFI_STATUS.WARN_FILE_SYSTEM:
                ThrowError("Warn File System", argExp, ln, mn, fp);
                break;
            case EFI_STATUS.WARN_RESET_REQUIRED:
                ThrowError("Warn Reset Required", argExp, ln, mn, fp);
                break;
        }
        return false;
    }
}