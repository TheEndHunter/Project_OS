using System;

namespace Efi
{
    [Flags]
    public enum EFI_VARIABLE_ATTRIBUTES : uint
    {
        NON_VOLATILE = 0x00000001,
        BOOTSERVICE_ACCESS = 0x00000002,
        RUNTIME_ACCESS = 0x00000004,
        HARDWARE_ERROR_RECORD = 0x00000008,
        /// <summary>
        /// This attribute is identified by the mnemonic 'HR' elsewhere
        /// in this specification.
        /// </summary>
        AUTHENTICATED_WRITE_ACCESS = 0x00000010,
        /// <summary>
        /// NOTE: EFI_VARIABLE_AUTHENTICATED_WRITE_ACCESS is deprecated
        /// and should be considered reserved.
        /// </summary>
        TIME_BASED_AUTHENTICATED_WRITE_ACCESS = 0x00000020,
        APPEND_WRITE = 0x00000040,
        /// <summary>
        /// This attribute indicates that the variable payload begins
        /// with an EFI_VARIABLE_AUTHENTICATION_3 structure, and
        /// potentially more structures as indicated by fields of this
        /// structure. See definition below and in SetVariable().
        /// </summary>
        ENHANCED_AUTHENTICATED_ACCESS = 0x00000080,

    }
}
