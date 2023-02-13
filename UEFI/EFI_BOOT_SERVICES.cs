using System;
using System.Runtime.InteropServices;

namespace Efi
{
    public unsafe delegate EFI_STATUS EFI_EVENT_NOTIFY(EFI_EVENT @event, void* context);

    public unsafe delegate EFI_STATUS EFI_ENTRY_POINT(EFI_HANDLE imageHandle, EFI_SYSTEM_TABLE* systemTable);

    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct EFI_BOOT_SERVICES
    {
        public readonly EFI_TABLE_HEADER Hdr;
        //
        // Task Priority Services
        //
        public readonly unsafe delegate* unmanaged<EFI_TPL, EFI_STATUS> RaiseTPL; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_TPL, EFI_STATUS> RestoreTPL; // EFI 1.0+
        //
        // Memory Services
        //
        public readonly unsafe delegate* unmanaged<EFI_ALLOCATE_TYPE, EFI_MEMORY_TYPE, UIntn, EFI_PHYSICAL_ADDRESS, EFI_STATUS> AllocatePages; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_PHYSICAL_ADDRESS, UIntn, EFI_STATUS> FreePages; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<UIntn*, EFI_MEMORY_DESCRIPTOR, UIntn*, UIntn*, uint*, EFI_STATUS> GetMemoryMap; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_MEMORY_TYPE, UIntn, void**, EFI_STATUS> AllocatePool; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<void*, EFI_STATUS> FreePool; // EFI 1.0+
        //
        // Event & Timer Services
        //
        public readonly unsafe delegate* unmanaged<uint, EFI_TPL, EFI_EVENT_NOTIFY, void*, EFI_EVENT*, EFI_STATUS> CreateEvent; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_EVENT, EFI_TIMER_DELAY, ulong, EFI_STATUS> SetTimer; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<UIntn, EFI_EVENT*, UIntn*, EFI_STATUS> WaitForEvent; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_EVENT, EFI_STATUS> SignalEvent; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_EVENT*, EFI_STATUS> CloseEvent; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_EVENT, EFI_STATUS> CheckEvent; // EFI 1.0+
        //
        // Protocol Handler Services
        //
        public readonly unsafe delegate* unmanaged<EFI_HANDLE*, Guid, EFI_INTERFACE_TYPE, void*, EFI_STATUS> InstallProtocolInterface; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_HANDLE*, Guid, void*, void*, EFI_STATUS> ReinstallProtocolInterface; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_HANDLE*, Guid, void*, EFI_STATUS> UninstallProtocolInterface; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_HANDLE, Guid*, void**, EFI_STATUS> HandleProtocol; // EFI 1.0+
        public readonly void* Reserved; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<Guid*, EFI_EVENT, void**, EFI_STATUS> RegisterProtocolNotify; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_LOCATE_SEARCH_TYPE, Guid*, void*, UIntn*, EFI_HANDLE*, EFI_STATUS> LocateHandle; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<Guid*, EFI_DEVICE_PATH_PROTOCOL**, EFI_HANDLE*, EFI_STATUS> LocateDevicePath; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<Guid*, void*, EFI_STATUS> InstallConfigurationTable; // EFI 1.0+
        //
        // Image Services
        //
        public readonly unsafe delegate* unmanaged<bool, EFI_HANDLE, EFI_DEVICE_PATH_PROTOCOL*, void*, UIntn, EFI_HANDLE*, EFI_STATUS> LoadImage; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_HANDLE, UIntn*, char**, EFI_STATUS> StartImage; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_HANDLE, EFI_STATUS, UIntn, char*, EFI_STATUS> Exit; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_HANDLE, EFI_STATUS> UnloadImage; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<EFI_HANDLE, UIntn, EFI_STATUS> ExitBootServices; // EFI 1.0+
        //
        // Miscellaneous Services
        //
        public readonly unsafe delegate* unmanaged<ulong*, EFI_STATUS> GetNextMonotonicCount; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<UIntn, EFI_STATUS> Stall; // EFI 1.0+
        public readonly unsafe delegate* unmanaged<UIntn, ulong, UIntn, char*, EFI_STATUS> SetWatchdogTimer; // EFI 1.0+
        //
        // DriverSupport Services
        //
        public readonly unsafe delegate* unmanaged<EFI_HANDLE, EFI_HANDLE*, EFI_DEVICE_PATH_PROTOCOL*, bool, EFI_STATUS> ConnectController; // EFI 1.1
        public readonly unsafe delegate* unmanaged<EFI_HANDLE, EFI_HANDLE, EFI_HANDLE, EFI_STATUS> DisconnectController;// EFI 1.1+
        //
        // Open and Close Protocol Services
        //
        public readonly unsafe delegate* unmanaged<EFI_HANDLE, Guid*, void**, EFI_HANDLE, EFI_HANDLE, EFI_OPEN_PROTOCOL, EFI_STATUS> OpenProtocol; // EFI 1.1+
        public readonly unsafe delegate* unmanaged<EFI_HANDLE, Guid*, EFI_HANDLE, EFI_HANDLE, EFI_STATUS> CloseProtocol; // EFI 1.1+
        public readonly unsafe delegate* unmanaged<EFI_HANDLE, Guid*, EFI_OPEN_PROTOCOL_INFORMATION_ENTRY**, UIntn*, EFI_STATUS> OpenProtocolInformation; // EFI 1.1+
        //
        // Library Services
        //
        public readonly unsafe delegate* unmanaged<EFI_HANDLE, Guid***, UIntn*, EFI_STATUS> ProtocolsPerHandle; // EFI 1.1+
        public readonly unsafe delegate* unmanaged<EFI_LOCATE_SEARCH_TYPE, Guid*, void*, UIntn*, EFI_HANDLE**, EFI_STATUS> LocateHandleBuffer; // EFI 1.1+
        public readonly unsafe delegate* unmanaged<Guid*, void*, void**, EFI_STATUS> LocateProtocol; // EFI 1.1+
        public readonly unsafe EFI_INSTALL_MULTIPLE_PROTOCOL InstallMultipleProtocolInterfaces; // EFI 1.1+
        public readonly unsafe EFI_UNINSTALL_MULTIPLE_PROTOCOL UninstallMultipleProtocolInterfaces; // EFI 1.1+
        //
        // 32-bit CRC Services
        //
        public readonly unsafe delegate* unmanaged<void*, UIntn, uint*, EFI_STATUS> CalculateCrc32; // EFI 1.1+
        //
        // Miscellaneous Services
        //
        public readonly unsafe delegate* unmanaged<void*, void*, UIntn, EFI_STATUS> CopyMem; // EFI 1.1+
        public readonly unsafe delegate* unmanaged<void*, UIntn, byte, EFI_STATUS> SetMem; // EFI 1.1+
        public readonly unsafe delegate* unmanaged<uint, EFI_TPL, EFI_EVENT_NOTIFY, void*, Guid*, EFI_EVENT*, EFI_STATUS> CreateEventEx; // UEFI 2.0+
    }
}
