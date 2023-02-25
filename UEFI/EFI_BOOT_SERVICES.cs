using System;
using System.Runtime.InteropServices;

namespace Efi {
    public unsafe delegate EFI_STATUS EFI_EVENT_NOTIFY(EFI_EVENT @event, void* context);

    public unsafe delegate EFI_STATUS EFI_ENTRY_POINT(EFI_HANDLE imageHandle, EFI_SYSTEM_TABLE* systemTable);

    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe struct EFI_BOOT_SERVICES {
        public readonly EFI_TABLE_HEADER Hdr;
        //
        // Task Priority Services
        //
        private readonly delegate* unmanaged<EFI_TPL, EFI_STATUS> _RaiseTPL; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_TPL, EFI_STATUS> _RestoreTPL; // EFI 1.0+
        //
        // Memory Services
        //
        private readonly delegate* unmanaged<EFI_ALLOCATE_TYPE, EFI_MEMORY_TYPE, UIntn, EFI_PHYSICAL_ADDRESS, EFI_STATUS> _AllocatePages; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_PHYSICAL_ADDRESS, UIntn, EFI_STATUS> _FreePages; // EFI 1.0+
        private readonly delegate* unmanaged<UIntn*, EFI_MEMORY_DESCRIPTOR, UIntn*, UIntn*, uint*, EFI_STATUS> _GetMemoryMap; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_MEMORY_TYPE, UIntn, void**, EFI_STATUS> _AllocatePool; // EFI 1.0+
        private readonly delegate* unmanaged<void*, EFI_STATUS> _FreePool; // EFI 1.0+
        //
        // Event & Timer Services
        //
        private readonly delegate* unmanaged<uint, EFI_TPL, EFI_EVENT_NOTIFY, void*, EFI_EVENT*, EFI_STATUS> _CreateEvent; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_EVENT, EFI_TIMER_DELAY, ulong, EFI_STATUS> _SetTimer; // EFI 1.0+
        private readonly delegate* unmanaged<UIntn, EFI_EVENT*, UIntn*, EFI_STATUS> _WaitForEvent; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_EVENT, EFI_STATUS> _SignalEvent; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_EVENT*, EFI_STATUS> _CloseEvent; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_EVENT, EFI_STATUS> _CheckEvent; // EFI 1.0+
        //
        // Protocol Handler Services
        //
        private readonly delegate* unmanaged<EFI_HANDLE*, Guid, EFI_INTERFACE_TYPE, void*, EFI_STATUS> _InstallProtocolInterface; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_HANDLE*, Guid, void*, void*, EFI_STATUS> _ReinstallProtocolInterface; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_HANDLE*, Guid, void*, EFI_STATUS> _UninstallProtocolInterface; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_HANDLE, Guid*, void**, EFI_STATUS> _HandleProtocol; // EFI 1.0+
        private readonly void* _Reserved; // EFI 1.0+
        private readonly delegate* unmanaged<Guid*, EFI_EVENT, void**, EFI_STATUS> _RegisterProtocolNotify; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_LOCATE_SEARCH_TYPE, Guid*, void*, UIntn*, EFI_HANDLE*, EFI_STATUS> _LocateHandle; // EFI 1.0+
        private readonly delegate* unmanaged<Guid*, EFI_DEVICE_PATH_PROTOCOL**, EFI_HANDLE*, EFI_STATUS> _LocateDevicePath; // EFI 1.0+
        private readonly delegate* unmanaged<Guid*, void*, EFI_STATUS> _InstallConfigurationTable; // EFI 1.0+
        //
        // Image Services
        //
        private readonly delegate* unmanaged<bool, EFI_HANDLE, EFI_DEVICE_PATH_PROTOCOL*, void*, UIntn, EFI_HANDLE*, EFI_STATUS> _LoadImage; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_HANDLE, UIntn*, char**, EFI_STATUS> _StartImage; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_HANDLE, EFI_STATUS, UIntn, char*, EFI_STATUS> _Exit; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_HANDLE, EFI_STATUS> _UnloadImage; // EFI 1.0+
        private readonly delegate* unmanaged<EFI_HANDLE, UIntn, EFI_STATUS> _ExitBootServices; // EFI 1.0+
        //
        // Miscellaneous Services
        //
        private readonly delegate* unmanaged<ulong*, EFI_STATUS> _GetNextMonotonicCount; // EFI 1.0+
        private readonly delegate* unmanaged<UIntn, EFI_STATUS> _Stall; // EFI 1.0+
        private readonly delegate* unmanaged<UIntn, ulong, UIntn, char*, EFI_STATUS> _SetWatchdogTimer; // EFI 1.0+
        //
        // DriverSupport Services
        //
        private readonly delegate* unmanaged<EFI_HANDLE, EFI_HANDLE*, EFI_DEVICE_PATH_PROTOCOL*, bool, EFI_STATUS> _ConnectController; // EFI 1.1
        private readonly delegate* unmanaged<EFI_HANDLE, EFI_HANDLE, EFI_HANDLE, EFI_STATUS> _DisconnectController;// EFI 1.1+
        //
        // Open and Close Protocol Services
        //
        private readonly delegate* unmanaged<EFI_HANDLE, Guid*, void**, EFI_HANDLE, EFI_HANDLE, EFI_OPEN_PROTOCOL, EFI_STATUS> _OpenProtocol; // EFI 1.1+
        private readonly delegate* unmanaged<EFI_HANDLE, Guid*, EFI_HANDLE, EFI_HANDLE, EFI_STATUS> _CloseProtocol; // EFI 1.1+
        private readonly delegate* unmanaged<EFI_HANDLE, Guid*, EFI_OPEN_PROTOCOL_INFORMATION_ENTRY**, UIntn*, EFI_STATUS> _OpenProtocolInformation; // EFI 1.1+
        //
        // Library Services
        //
        private readonly delegate* unmanaged<EFI_HANDLE, Guid***, UIntn*, EFI_STATUS> _ProtocolsPerHandle; // EFI 1.1+
        private readonly delegate* unmanaged<EFI_LOCATE_SEARCH_TYPE, Guid*, void*, UIntn*, EFI_HANDLE**, EFI_STATUS> _LocateHandleBuffer; // EFI 1.1+
        private readonly delegate* unmanaged<Guid*, void*, void**, EFI_STATUS> _LocateProtocol; // EFI 1.1+
        private readonly EFI_INSTALL_MULTIPLE_PROTOCOL _InstallMultipleProtocolInterfaces; // EFI 1.1+
        private readonly EFI_UNINSTALL_MULTIPLE_PROTOCOL _UninstallMultipleProtocolInterfaces; // EFI 1.1+
        //
        // 32-bit CRC Services
        //
        private readonly delegate* unmanaged<void*, UIntn, uint*, EFI_STATUS> _CalculateCrc32; // EFI 1.1+
        //
        // Miscellaneous Services
        //
        private readonly delegate* unmanaged<void*, void*, UIntn, EFI_STATUS> _CopyMem; // EFI 1.1+
        private readonly delegate* unmanaged<void*, UIntn, byte, EFI_STATUS> _SetMem; // EFI 1.1+
        private readonly delegate* unmanaged<uint, EFI_TPL, EFI_EVENT_NOTIFY, void*, Guid*, EFI_EVENT*, EFI_STATUS> _CreateEventEx; // UEFI 2.0+

        //
        // Task Priority Services
        //
        public EFI_STATUS RaiseTPL(EFI_TPL tpl) {
            return _RaiseTPL(tpl);
        } // EFI 1.0+
        public EFI_STATUS RestoreTPL(EFI_TPL tpl) {
            return _RestoreTPL(tpl);
        }
        //
        // Memory Services
        //
        public EFI_STATUS AllocatePages(EFI_ALLOCATE_TYPE allocType, EFI_MEMORY_TYPE memoryType, UIntn count, EFI_PHYSICAL_ADDRESS addr) {
            return _AllocatePages(allocType, memoryType, count, addr);
        }// EFI 1.0+
        public EFI_STATUS FreePages(EFI_PHYSICAL_ADDRESS addr, UIntn count) {
            return _FreePages(addr, count);
        }

        public EFI_STATUS GetMemoryMap(UIntn* a, EFI_MEMORY_DESCRIPTOR descriptor, UIntn* b, UIntn* c, uint* d) {
            return _GetMemoryMap(a, descriptor, b, c, d);
        }

        public EFI_STATUS AllocatePool(EFI_MEMORY_TYPE memoryType, UIntn size, void** location) {
            return _AllocatePool(memoryType, size, location);
        }
        public EFI_STATUS FreePool(void* addr) {
            return _FreePool(addr);
        }

        //
        // Event & Timer Services
        //
        public EFI_STATUS CreateEvent(uint a, EFI_TPL tpl, EFI_EVENT_NOTIFY func, void* b, EFI_EVENT* e) {
            return _CreateEvent(a, tpl, func, b, e);
        } // EFI 1.0+

        public EFI_STATUS SetTimer(EFI_EVENT e, EFI_TIMER_DELAY TimerDelay, ulong time) {
            return _SetTimer(e, TimerDelay, time);
        }

        public EFI_STATUS WaitForEvent(UIntn a, EFI_EVENT* e, UIntn* b) {
            return _WaitForEvent(a, e, b);
        }

        public EFI_STATUS SignalEvent(EFI_EVENT e) {
            return _SignalEvent(e);
        }
        public EFI_STATUS CloseEvent(EFI_EVENT* e) {
            return _CloseEvent(e);
        }
        public EFI_STATUS CheckEvent(EFI_EVENT e) {
            return _CheckEvent(e);
        }
        //
        // Protocol Handler Services
        //
        public EFI_STATUS InstallProtocolInterface(EFI_HANDLE* handle, Guid guid, EFI_INTERFACE_TYPE interfaceType, void* interfacePointer) {
            return _InstallProtocolInterface(handle, guid, interfaceType, interfacePointer);
        }
        public EFI_STATUS ReinstallProtocolInterface(EFI_HANDLE* handle, Guid guid, void* oldinterface, void* newinterface) {
            return _ReinstallProtocolInterface(handle, guid, oldinterface, newinterface);
        }
        public EFI_STATUS UninstallProtocolInterface(EFI_HANDLE* handle, Guid guid, void* interfacePointer) {
            return _UninstallProtocolInterface(handle, guid, interfacePointer);
        }
        public EFI_STATUS HandleProtocol(EFI_HANDLE handle, Guid* guid, void** protocolhandler) {
            return _HandleProtocol(handle, guid, protocolhandler);
        }
        public EFI_STATUS RegisterProtocolNotify(Guid* guid, EFI_EVENT e, void** handler) {
            return _RegisterProtocolNotify(guid, e, handler);
        }
        public EFI_STATUS LocateHandle(EFI_LOCATE_SEARCH_TYPE searchType, Guid* guid, void* a, UIntn* b, EFI_HANDLE* handle) {
            return _LocateHandle(searchType, guid, a, b, handle);
        }
        public EFI_STATUS LocateDevicePath(Guid* guid, EFI_DEVICE_PATH_PROTOCOL** devicePathProtocol, EFI_HANDLE* handle) {
            return _LocateDevicePath(guid, devicePathProtocol, handle);
        }
        public EFI_STATUS InstallConfigurationTable(Guid* guid, void* table) {
            return _InstallConfigurationTable(guid, table);
        }
        //
        // Image Services
        //
        public EFI_STATUS LoadImage(bool a, EFI_HANDLE handle, EFI_DEVICE_PATH_PROTOCOL* devicePath, void* b, UIntn c, EFI_HANDLE* d) {
            return _LoadImage(a, handle, devicePath, b, c, d);
        }// EFI 1.0+
        public EFI_STATUS StartImage(EFI_HANDLE handle, UIntn* a, char** b) {
            return _StartImage(handle, a, b);
        }// EFI 1.0+
        public EFI_STATUS Exit(EFI_HANDLE handle, EFI_STATUS exitCode, UIntn a, char* b) {
            return _Exit(handle, exitCode, a, b);
        }
        // EFI 1.0+
        public EFI_STATUS UnloadImage(EFI_HANDLE handle) {
            return _UnloadImage(handle);
        } // EFI 1.0+
        public EFI_STATUS ExitBootServices(EFI_HANDLE handle, UIntn a) {
            return _ExitBootServices(handle, a);
        }// EFI 1.0+

        //
        // Miscellaneous Services
        //
        public EFI_STATUS GetNextMonotonicCount(ulong* count) {
            return _GetNextMonotonicCount(count);
        }// EFI 1.0+
        public EFI_STATUS Stall(UIntn count) {
            return _Stall(count);
        }// EFI 1.0+
        public EFI_STATUS SetWatchdogTimer(UIntn a, ulong b, UIntn c, char* d) {
            return _SetWatchdogTimer(a, b, c, d);
        }// EFI 1.0+

        //
        // DriverSupport Services
        //
        public EFI_STATUS ConnectController(EFI_HANDLE handleA, EFI_HANDLE* handleB, EFI_DEVICE_PATH_PROTOCOL* devicePath, bool c) // EFI 1.1
        {
            return _ConnectController(handleA, handleB, devicePath, c);
        }
        public EFI_STATUS DisconnectController(EFI_HANDLE handleA, EFI_HANDLE handleB, EFI_HANDLE handleC)// EFI 1.1+
        {
            return _DisconnectController(handleA, handleB, handleC);
        }

        //
        // Open and Close Protocol Services
        //
        public EFI_STATUS OpenProtocol(EFI_HANDLE handle, Guid* guid, void** protocol, EFI_HANDLE a, EFI_HANDLE b, EFI_OPEN_PROTOCOL c) {
            return _OpenProtocol(handle, guid, protocol, a, b, c);
        }// EFI 1.1+
        public EFI_STATUS CloseProtocol(EFI_HANDLE handle, Guid* guid, EFI_HANDLE a, EFI_HANDLE b) {
            return _CloseProtocol(handle, guid, a, b);
        }// EFI 1.1+
        public EFI_STATUS OpenProtocolInformation(EFI_HANDLE handle, Guid* guid, EFI_OPEN_PROTOCOL_INFORMATION_ENTRY** entry, UIntn* a) {
            return _OpenProtocolInformation(handle, guid, entry, a);
        }// EFI 1.1+

        //
        // Library Services
        //
        public EFI_STATUS ProtocolsPerHandle(EFI_HANDLE handle, Guid*** guid, UIntn* i) {
            return _ProtocolsPerHandle(handle, guid, i);
        }// EFI 1.1+

        public EFI_STATUS LocateHandleBuffer(EFI_LOCATE_SEARCH_TYPE searchType, Guid* guid, void* a, UIntn* b, EFI_HANDLE** handle) {
            return _LocateHandleBuffer(searchType, guid, a, b, handle);
        }// EFI 1.1+
        public EFI_STATUS LocateProtocol(Guid* protocol, nint registration, void** @interface) {
            return _LocateProtocol(protocol, (void*)registration, @interface);
        }// EFI 1.1+
        public EFI_STATUS LocateProtocol(Guid* protocol, void* registration, void** @interface) {
            return _LocateProtocol(protocol, registration, @interface);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11, EFI_HANDLE* arg12) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11, EFI_HANDLE* arg12, EFI_HANDLE* arg13) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11, EFI_HANDLE* arg12, EFI_HANDLE* arg13, EFI_HANDLE* arg14) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }// EFI 1.1+
        public EFI_STATUS InstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11, EFI_HANDLE* arg12, EFI_HANDLE* arg13, EFI_HANDLE* arg14, EFI_HANDLE* arg15) {
            return _InstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11, EFI_HANDLE* arg12) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11, EFI_HANDLE* arg12, EFI_HANDLE* arg13) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11, EFI_HANDLE* arg12, EFI_HANDLE* arg13, EFI_HANDLE* arg14) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }// EFI 1.1+
        public EFI_STATUS UninstallMultipleProtocolInterfaces(EFI_HANDLE* arg, EFI_HANDLE* arg1, EFI_HANDLE* arg2, EFI_HANDLE* arg3, EFI_HANDLE* arg4, EFI_HANDLE* arg5, EFI_HANDLE* arg6, EFI_HANDLE* arg7, EFI_HANDLE* arg8, EFI_HANDLE* arg9, EFI_HANDLE* arg10, EFI_HANDLE* arg11, EFI_HANDLE* arg12, EFI_HANDLE* arg13, EFI_HANDLE* arg14, EFI_HANDLE* arg15) {
            return _UninstallMultipleProtocolInterfaces.Invoke(arg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }// EFI 1.1+

        //
        // 32-bit CRC Services
        //
        public EFI_STATUS CalculateCrc32(void* a, UIntn b, uint* c) {
            return _CalculateCrc32(a, b, c);
        }

        //
        // Miscellaneous Services
        //
        public EFI_STATUS CopyMem(void* src, void* dest, UIntn size) {
            return _CopyMem(src, dest, size);
        }
        public EFI_STATUS SetMem(void* src, UIntn size, byte value) {
            return _SetMem(src, size, value);
        }
        public EFI_STATUS CreateEventEx(uint a, EFI_TPL tpl, EFI_EVENT_NOTIFY func, void* b, Guid* guid, EFI_EVENT* handle) {
            return _CreateEventEx(a, tpl, func, b, guid, handle);
        }
    }
}
