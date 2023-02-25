using Efi;

using System;
using System.Runtime.InteropServices;

namespace Efi {
    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct EFI_RUNTIME_SERVICES {
        public readonly EFI_TABLE_HEADER Hdr;
        //
        // Time Services
        //
        public readonly unsafe delegate* unmanaged<EFI_TIME*, EFI_TIME_CAPABILITIES*, EFI_STATUS> GetTime;
        public readonly unsafe delegate* unmanaged<EFI_TIME*, EFI_STATUS> SetTime;
        public readonly unsafe delegate* unmanaged<bool*, bool*, EFI_TIME*, EFI_STATUS> GetWakeupTime;
        public readonly unsafe delegate* unmanaged<bool, EFI_TIME*, EFI_STATUS> SetWakeupTime;
        //
        // Virtual Memory Services
        //
        public readonly unsafe delegate* unmanaged<UIntn, UIntn, uint, EFI_MEMORY_DESCRIPTOR*, EFI_STATUS> SetVirtualAddressMap;
        public readonly unsafe delegate* unmanaged<UIntn, void**, EFI_STATUS> ConvertPointer;
        //
        // Variable Services
        //
        public readonly unsafe delegate* unmanaged<char*, Guid*, EFI_VARIABLE_ATTRIBUTES*, UIntn*, void*, EFI_STATUS> GetVariable;
        public readonly unsafe delegate* unmanaged<UIntn*, char*, Guid*, EFI_STATUS> GetNextVariableName;
        public readonly unsafe delegate* unmanaged<char*, Guid*, EFI_VARIABLE_ATTRIBUTES, UIntn, void*, EFI_STATUS> SetVariable;
        //
        // Miscellaneous Services
        //
        public readonly unsafe delegate* unmanaged<uint*, EFI_STATUS> GetNextHighMonotonicCount;
        public readonly unsafe delegate* unmanaged<EFI_RESET_TYPE, EFI_STATUS, UIntn, void*, EFI_STATUS> ResetSystem;
        //
        // UEFI 2.0 Capsule Services
        // 
        public readonly unsafe delegate* unmanaged<EFI_CAPSULE_HEADER**, UIntn, EFI_PHYSICAL_ADDRESS, EFI_STATUS> UpdateCapsule;
        public readonly unsafe delegate* unmanaged<EFI_CAPSULE_HEADER**, UIntn, ulong**, EFI_RESET_TYPE*, EFI_STATUS> QueryCapsuleCapabilities;
        //
        // Miscellaneous UEFI 2.0 Service
        //
        public readonly unsafe delegate* unmanaged<EFI_VARIABLE_ATTRIBUTES, ulong*, ulong*, ulong*, EFI_STATUS> QueryVariableInfo;
    }
}
