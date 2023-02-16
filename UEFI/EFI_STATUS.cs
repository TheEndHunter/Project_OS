namespace Efi
{
    public enum EFI_STATUS : UIntn
    {
#if TARGET_64BIT
        /// <summary>
        /// The operation completed successfully.
        /// </summary>
        SUCCESS = 0,
        /// <summary>
        /// The image failed to load.
        /// </summary>
        LOAD_ERROR = 0x8000_0000_0000_0001,
        /// <summary>
        /// _A parameter was incorrect.
        /// </summary>
        INVALID_PARAMETER,
        /// <summary>
        /// The operation is not supported.
        /// </summary>
        UNSUPPORTED,
        /// <summary>
        /// The buffer was not the proper size for the request.
        /// </summary>
        BAD_BUFFER_SIZE,
        /// <summary>
        /// The buffer is not large enough to hold the requested data. The
        /// required buffer size is returned in the appropriate parameter
        /// when this error occurs.
        /// </summary>
        BUFFER_TOO_SMALL,
        /// <summary>
        /// There is no data pending upon return.
        /// </summary>
        NOT_READY,
        /// <summary>
        /// The physical device reported an error while attempting theoperation.
        /// </summary>
        DEVICE_ERROR,
        /// <summary>
        /// The device cannot be written to.
        /// </summary>
        WRITE_PROTECTED,
        /// <summary>
        /// _A resource has run out.
        /// </summary>
        OUT_OF_RESOURCES,
        /// <summary>
        /// An inconstancy was detected on the file system causing the operating to fail.
        /// </summary>
        VOLUME_CORRUPTED,
        /// <summary>
        /// There is no more space on the file system.
        /// </summary>
        VOLUME_FULL,
        /// <summary>
        /// The device does not contain any medium to perform the operation.
        /// </summary>
        NO_MEDIA,
        /// <summary>
        /// The medium in the device has changed since the last access.
        /// </summary>
        MEDIA_CHANGED,
        /// <summary>
        /// The item was not found.
        /// </summary>
        NOT_FOUND,
        /// <summary>
        /// Access was denied.
        /// </summary>
        ACCESS_DENIED,
        /// <summary>
        /// The server was not found or did not respond to the request.
        /// </summary>
        NO_RESPONSE,
        /// <summary>
        /// _A mapping to a device does not exist.
        /// </summary>
        NO_MAPPING,
        /// <summary>
        /// The timeout time expired.
        /// </summary>
        TIMEOUT,
        /// <summary>
        /// The protocol has not been started.
        /// </summary>
        NOT_STARTED,
        /// <summary>
        /// The protocol has already been started.
        /// </summary>
        ALREADY_START,
        /// <summary>
        /// The operation was aborted.
        /// </summary>
        ABORTED,
        /// <summary>
        /// An ICMP error occurred during the network operation.
        /// </summary>
        ICMP_ERROR,
        /// <summary>
        /// _A TFTP error occurred during the network operation.
        /// </summary>
        TFTP_ERROR,
        /// <summary>
        /// _A protocol error occurred during the network operation.
        /// </summary>
        PROTOCOL_ERROR,
        /// <summary>
        /// The function encountered an internal version that was
        /// incompatible with a version requested by the caller.
        /// </summary>
        INCOMPATIBLE_VERSION,
        /// <summary>
        /// The function was not performed due to a security violation.
        /// </summary>
        SECURITY_VIOLATION,
        /// <summary>
        /// _A CRC error was detected.
        /// </summary>
        CRC_ERROR,
        /// <summary>
        /// Beginning or end of media was reached
        /// </summary>
        END_OF_MEDIA,
        /// <summary>
        /// The end of the file was reached.
        /// </summary>
        END_OF_FILE,
        /// <summary>
        /// The language specified was invalid.
        /// </summary>
        INVALID_LANGUAGE,
        /// <summary>
        /// The security status of the data is unknown or compromised and
        /// the data must be updated or replaced to restore a valid security
        /// status.
        /// </summary>
        COMPROMISED_DATA,
        /// <summary>
        /// There is an address conflict address allocation
        /// </summary>
        IP_ADDRESS_CONFLICT,
        /// <summary>
        /// _A HTTP error occurred during the network operation
        /// </summary>
        HTTP_ERROR,
        /// <summary>
        /// The string contained one or more characters that the device
        /// could not render and were skipped.
        /// </summary>
        WARN_UNKNOWN_GLYPH = 0x0000_0000_0000_0001,
        /// <summary>
        /// The handle was closed, but the file was not deleted.
        /// </summary>
        WARN_DELETE_FAILURE,
        /// <summary>
        /// The handle was closed, but the data to the file was not flushed
        ///properly.
        /// </summary>
        WARN_WRITE_FAILURE,
        /// <summary>
        /// The resulting buffer was too small, and the data was truncated to
        ///the buffer size.
        /// </summary>
        WARN_BUFFER_TOO_SMALL,
        /// <summary>
        /// The data has not been updated within the timeframe set by local
        /// policy for this type of data.
        /// </summary>

        WARN_STALE_DATA,
        /// <summary>
        /// The resulting buffer contains UEFI-compliant file system.
        /// </summary>
        WARN_FILE_SYSTEM,
        /// <summary>
        /// The operation will be processed across a system reset.
        /// </summary>
        WARN_RESET_REQUIRED,
#else
        /// <summary>
        /// The operation completed successfully.
        /// </summary>
        SUCCESS = 0,
        /// <summary>
        /// The image failed to load.
        /// </summary>
        LOAD_ERROR = 0x8000_0001,
        /// <summary>
        /// A parameter was incorrect.
        /// </summary>
        INVALID_PARAMETER,
        /// <summary>
        /// The operation is not supported.
        /// </summary>
        UNSUPPORTED,
        /// <summary>
        /// The buffer was not the proper size for the request.
        /// </summary>
        BAD_BUFFER_SIZE,
        /// <summary>
        /// The buffer is not large enough to hold the requested data. The
        /// required buffer size is returned in the appropriate parameter
        /// when this error occurs.
        /// </summary>
        BUFFER_TOO_SMALL,
        /// <summary>
        /// There is no data pending upon return.
        /// </summary>
        NOT_READY,
        /// <summary>
        /// The physical device reported an error while attempting theoperation.
        /// </summary>
        DEVICE_ERROR,
        /// <summary>
        /// The device cannot be written to.
        /// </summary>
        WRITE_PROTECTED,
        /// <summary>
        /// A resource has run out.
        /// </summary>
        OUT_OF_RESOURCES,
        /// <summary>
        /// An inconstancy was detected on the file system causing the operating to fail.
        /// </summary>
        VOLUME_CORRUPTED,
        /// <summary>
        /// There is no more space on the file system.
        /// </summary>
        VOLUME_FULL,
        /// <summary>
        /// The device does not contain any medium to perform the operation.
        /// </summary>
        NO_MEDIA,
        /// <summary>
        /// The medium in the device has changed since the last access.
        /// </summary>
        MEDIA_CHANGED,
        /// <summary>
        /// The item was not found.
        /// </summary>
        NOT_FOUND,
        /// <summary>
        /// Access was denied.
        /// </summary>
        ACCESS_DENIED,
        /// <summary>
        /// The server was not found or did not respond to the request.
        /// </summary>
        NO_RESPONSE,
        /// <summary>
        /// A mapping to a device does not exist.
        /// </summary>
        NO_MAPPING,
        /// <summary>
        /// The timeout time expired.
        /// </summary>
        TIMEOUT,
        /// <summary>
        /// The protocol has not been started.
        /// </summary>
        NOT_STARTED,
        /// <summary>
        /// The protocol has already been started.
        /// </summary>
        ALREADY_START,
        /// <summary>
        /// The operation was aborted.
        /// </summary>
        ABORTED,
        /// <summary>
        /// An ICMP error occurred during the network operation.
        /// </summary>
        ICMP_ERROR,
        /// <summary>
        /// A TFTP error occurred during the network operation.
        /// </summary>
        TFTP_ERROR,
        /// <summary>
        /// A protocol error occurred during the network operation.
        /// </summary>
        PROTOCOL_ERROR,
        /// <summary>
        /// The function encountered an internal version that was
        /// incompatible with a version requested by the caller.
        /// </summary>
        INCOMPATIBLE_VERSION,
        /// <summary>
        /// The function was not performed due to a security violation.
        /// </summary>
        SECURITY_VIOLATION,
        /// <summary>
        /// A CRC error was detected.
        /// </summary>
        CRC_ERROR,
        /// <summary>
        /// Beginning or end of media was reached
        /// </summary>
        END_OF_MEDIA,
        /// <summary>
        /// The end of the file was reached.
        /// </summary>
        END_OF_FILE,
        /// <summary>
        /// The language specified was invalid.
        /// </summary>
        INVALID_LANGUAGE,
        /// <summary>
        /// The security status of the data is unknown or compromised and
        /// the data must be updated or replaced to restore a valid security
        /// status.
        /// </summary>
        COMPROMISED_DATA,
        /// <summary>
        /// There is an address conflict address allocation
        /// </summary>
        IP_ADDRESS_CONFLICT,
        /// <summary>
        /// A HTTP error occurred during the network operation
        /// </summary>
        HTTP_ERROR,
        /// <summary>
        /// The string contained one or more characters that the device
        /// could not render and were skipped.
        /// </summary>
        WARN_UNKNOWN_GLYPH = 0x0000_0001,
        /// <summary>
        /// The handle was closed, but the file was not deleted.
        /// </summary>
        WARN_DELETE_FAILURE,
        /// <summary>
        /// The handle was closed, but the data to the file was not flushed
        ///properly.
        /// </summary>
        WARN_WRITE_FAILURE,
        /// <summary>
        /// The resulting buffer was too small, and the data was truncated to
        ///the buffer size.
        /// </summary>
        WARN_BUFFER_TOO_SMALL,
        /// <summary>
        /// The data has not been updated within the timeframe set by local
        /// policy for this type of data.
        /// </summary>

        WARN_STALE_DATA,
        /// <summary>
        /// The resulting buffer contains UEFI-compliant file system.
        /// </summary>
        WARN_FILE_SYSTEM,
        /// <summary>
        /// The operation will be processed across a system reset.
        /// </summary>
        WARN_RESET_REQUIRED,
#endif
    }
}
