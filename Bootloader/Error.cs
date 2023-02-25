using Efi;

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace bootloader {
    public static unsafe class Error {

        public static void WriteWarning(EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* buffer, char* errMsg, [CallerArgumentExpression(nameof(errMsg))] string argExp = "", [CallerLineNumber] uint ln = 0, [CallerMemberName] string mn = "", [CallerFilePath] string fp = "") {
            buffer->SetAttribute(Program.WarningColor);
            fixed (char* nl = StringHelp.NewLine) {
                buffer->OutputString(errMsg);
                buffer->OutputString(nl);
                fixed (char* a = mn) {
                    buffer->OutputString(a);
                }
                fixed (char* b = StringHelp.Space) {
                    buffer->OutputString(b);
                }
                fixed (char* c = fp) {
                    buffer->OutputString(c);
                }
                buffer->OutputString(nl);
            }
            buffer->SetAttribute(Program.DefaultColor);
        }

        [DoesNotReturn]
        public static void ThrowError(EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL* buffer, char* errMsg, [CallerArgumentExpression(nameof(errMsg))] string argExp = "", [CallerLineNumber] uint ln = 0, [CallerMemberName] string mn = "", [CallerFilePath] string fp = "") {
            buffer->SetAttribute(Program.ErrorColor);
            buffer->Reset();
            buffer->ClearScreen();
            fixed (char* nl = StringHelp.NewLine) {
                buffer->OutputString(errMsg);
                buffer->OutputString(nl);
                fixed (char* a = mn) {
                    buffer->OutputString(a);
                }
                fixed (char* b = StringHelp.Space) {
                    buffer->OutputString(b);
                }
                fixed (char* c = fp) {
                    buffer->OutputString(c);
                }
                buffer->OutputString(nl);
            }
            while (true) ;
        }

        public static bool CheckEFIError(EFI_STATUS s) {
            return s switch {
                EFI_STATUS.LOAD_ERROR => true,
                EFI_STATUS.INVALID_PARAMETER => true,
                EFI_STATUS.UNSUPPORTED => true,
                EFI_STATUS.BAD_BUFFER_SIZE => true,
                EFI_STATUS.BUFFER_TOO_SMALL => true,
                EFI_STATUS.NOT_READY => true,
                EFI_STATUS.DEVICE_ERROR => true,
                EFI_STATUS.WRITE_PROTECTED => true,
                EFI_STATUS.OUT_OF_RESOURCES => true,
                EFI_STATUS.VOLUME_CORRUPTED => true,
                EFI_STATUS.VOLUME_FULL => true,
                EFI_STATUS.NO_MEDIA => true,
                EFI_STATUS.MEDIA_CHANGED => true,
                EFI_STATUS.NOT_FOUND => true,
                EFI_STATUS.ACCESS_DENIED => true,
                EFI_STATUS.NO_RESPONSE => true,
                EFI_STATUS.NO_MAPPING => true,
                EFI_STATUS.TIMEOUT => true,
                EFI_STATUS.NOT_STARTED => true,
                EFI_STATUS.ALREADY_START => true,
                EFI_STATUS.ABORTED => true,
                EFI_STATUS.ICMP_ERROR => true,
                EFI_STATUS.TFTP_ERROR => true,
                EFI_STATUS.PROTOCOL_ERROR => true,
                EFI_STATUS.INCOMPATIBLE_VERSION => true,
                EFI_STATUS.SECURITY_VIOLATION => true,
                EFI_STATUS.CRC_ERROR => true,
                EFI_STATUS.END_OF_MEDIA => true,
                EFI_STATUS.END_OF_FILE => true,
                EFI_STATUS.INVALID_LANGUAGE => true,
                EFI_STATUS.COMPROMISED_DATA => true,
                EFI_STATUS.IP_ADDRESS_CONFLICT => true,
                EFI_STATUS.HTTP_ERROR => true,
                _ => false,
            };
        }

        public static char* ToCharPtr(this EFI_STATUS status) {
            switch (status) {
                case EFI_STATUS.SUCCESS:
                    return null;
                case EFI_STATUS.LOAD_ERROR:
                    fixed (char* c = Err_LoadError)
                        return c;
                case EFI_STATUS.INVALID_PARAMETER:
                    fixed (char* c = Err_InvalidParameter)
                        return c;
                case EFI_STATUS.UNSUPPORTED:
                    fixed (char* c = Err_Unsupported)
                        return c;
                case EFI_STATUS.BAD_BUFFER_SIZE:
                    fixed (char* c = Err_BadBufferSize)
                        return c;
                case EFI_STATUS.BUFFER_TOO_SMALL:
                    fixed (char* c = Err_BufferTooSmall)
                        return c;
                case EFI_STATUS.NOT_READY:
                    fixed (char* c = Err_NotReady)
                        return c;
                case EFI_STATUS.DEVICE_ERROR:
                    fixed (char* c = Err_DeviceError)
                        return c;
                case EFI_STATUS.WRITE_PROTECTED:
                    fixed (char* c = Err_WriteProtected)
                        return c;
                case EFI_STATUS.OUT_OF_RESOURCES:
                    fixed (char* c = Err_OutOfResources)
                        return c;
                case EFI_STATUS.VOLUME_CORRUPTED:
                    fixed (char* c = Err_VolumeCorrupt)
                        return c;
                case EFI_STATUS.VOLUME_FULL:
                    fixed (char* c = Err_VolumeFull)
                        return c;
                case EFI_STATUS.NO_MEDIA:
                    fixed (char* c = Err_NoMedia)
                        return c;
                case EFI_STATUS.MEDIA_CHANGED:
                    fixed (char* c = Err_MediaChanged)
                        return c;
                case EFI_STATUS.NOT_FOUND:
                    fixed (char* c = Err_NotFound)
                        return c;
                case EFI_STATUS.ACCESS_DENIED:
                    fixed (char* c = Err_AccessDenied)
                        return c;
                case EFI_STATUS.NO_RESPONSE:
                    fixed (char* c = Err_NoResponse)
                        return c;
                case EFI_STATUS.NO_MAPPING:
                    fixed (char* c = Err_NoMapping)
                        return c;
                case EFI_STATUS.TIMEOUT:
                    fixed (char* c = Err_TimeOut)
                        return c;
                case EFI_STATUS.NOT_STARTED:
                    fixed (char* c = Err_NotStarted)
                        return c;
                case EFI_STATUS.ALREADY_START:
                    fixed (char* c = Err_AlreadyStarted)
                        return c;
                case EFI_STATUS.ABORTED:
                    fixed (char* c = Err_Aborted)
                        return c;
                case EFI_STATUS.ICMP_ERROR:
                    fixed (char* c = Err_ICMPError)
                        return c;
                case EFI_STATUS.TFTP_ERROR:
                    fixed (char* c = Err_TFTPError)
                        return c;
                case EFI_STATUS.PROTOCOL_ERROR:
                    fixed (char* c = Err_ProtocolError)
                        return c;
                case EFI_STATUS.INCOMPATIBLE_VERSION:
                    fixed (char* c = Err_IncompatibleVersion)
                        return c;
                case EFI_STATUS.SECURITY_VIOLATION:
                    fixed (char* c = Err_SecurityVoilation)
                        return c;
                case EFI_STATUS.CRC_ERROR:
                    fixed (char* c = Err_CrcError)
                        return c;
                case EFI_STATUS.END_OF_MEDIA:
                    fixed (char* c = Err_EndOfMedia)
                        return c;
                case EFI_STATUS.END_OF_FILE:
                    fixed (char* c = Err_EndOfFile)
                        return c;
                case EFI_STATUS.INVALID_LANGUAGE:
                    fixed (char* c = Err_InvalidLanguage)
                        return c;
                case EFI_STATUS.COMPROMISED_DATA:
                    fixed (char* c = Err_CompromisedData)
                        return c;
                case EFI_STATUS.IP_ADDRESS_CONFLICT:
                    fixed (char* c = Err_IPAddressConflict)
                        return c;
                case EFI_STATUS.HTTP_ERROR:
                    fixed (char* c = Err_HTTPError)
                        return c;
                case EFI_STATUS.WARN_UNKNOWN_GLYPH:
                    fixed (char* c = Wrn_UnknownGlyph)
                        return c;
                case EFI_STATUS.WARN_DELETE_FAILURE:
                    fixed (char* c = Wrn_DeleteFailure)
                        return c;
                case EFI_STATUS.WARN_WRITE_FAILURE:
                    fixed (char* c = Wrn_WriteFailure)
                        return c;
                case EFI_STATUS.WARN_BUFFER_TOO_SMALL:
                    fixed (char* c = Wrn_BufferTooSmall)
                        return c;
                case EFI_STATUS.WARN_STALE_DATA:
                    fixed (char* c = Wrn_StaleData)
                        return c;
                case EFI_STATUS.WARN_FILE_SYSTEM:
                    fixed (char* c = Wrn_FileSystem)
                        return c;
                case EFI_STATUS.WARN_RESET_REQUIRED:
                    fixed (char* c = Wrn_ResetRequired)
                        return c;
                default:
                    fixed (char* c = Unknown)
                        return c;
            }
        }

        public const string Unknown = "Unknown";
        public const string Success = "Success";
        public const string Err_LoadError = "Load Error";
        public const string Err_InvalidParameter = "Invalid Parameter";
        public const string Err_Unsupported = "Unsupported";
        public const string Err_BadBufferSize = "Bad Buffer Size";
        public const string Err_BufferTooSmall = "Buffer To Small";
        public const string Err_NotReady = "Not Ready";
        public const string Err_DeviceError = "Device Error";
        public const string Err_WriteProtected = "Write Protected";
        public const string Err_OutOfResources = "Out Of Resources";
        public const string Err_VolumeCorrupt = "Volume Corrupted";
        public const string Err_VolumeFull = "Volume Full";
        public const string Err_NoMedia = "No Media";
        public const string Err_MediaChanged = "Media Changed";
        public const string Err_NotFound = "Not Found";
        public const string Err_AccessDenied = "Access Denied";
        public const string Err_NoResponse = "No Response";
        public const string Err_NoMapping = "No Mapping";
        public const string Err_TimeOut = "Time Out";
        public const string Err_NotStarted = "Not Started";
        public const string Err_AlreadyStarted = "Already Started";
        public const string Err_Aborted = "Aborted";
        public const string Err_ICMPError = "ICMP Error";
        public const string Err_TFTPError = "TFTP Error";
        public const string Err_ProtocolError = "Protocol Error";
        public const string Err_IncompatibleVersion = "Incompatible Version";
        public const string Err_SecurityVoilation = "Security Violation";
        public const string Err_CrcError = "Crc Error";
        public const string Err_EndOfMedia = "End Of Media";
        public const string Err_EndOfFile = "EndOf File";
        public const string Err_InvalidLanguage = "Invalid Language";
        public const string Err_CompromisedData = "Compromised Data";
        public const string Err_IPAddressConflict = "IP Address Conflict";
        public const string Err_HTTPError = "HTTP Error";
        public const string Wrn_UnknownGlyph = "Warn Unknown Glyph";
        public const string Wrn_DeleteFailure = "Warn Delete Failure";
        public const string Wrn_WriteFailure = "Warn Write Failure";
        public const string Wrn_BufferTooSmall = "Warn Buffer Too Small";
        public const string Wrn_StaleData = "Warn Stale Data";
        public const string Wrn_FileSystem = "Warn File System";
        public const string Wrn_ResetRequired = "Warn Reset Required";
    }
}