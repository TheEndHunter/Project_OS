
#if TARGET_64BIT
global using UIntn = System.UInt64;
global using Intn = System.Int64;
#else
global using UIntn = System.UInt32;
global using Intn = System.Int32;
#endif

global using EFI_PHYSICAL_ADDRESS = System.UIntPtr;
global using EFI_VIRTUAL_ADDRESS = System.UIntPtr;