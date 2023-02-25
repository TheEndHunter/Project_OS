﻿using System;

namespace Efi {
    [Flags]
    public enum EFI_MEMORY_ATTRIBUTES : ulong {
        /// <summary>
        /// Memory cacheability attribute: The memory region supports being
        // configured as not cacheable. 
        /// </summary>
        MEMORY_UC = 0x0000000000000001,
        /// <summary>
        /// Memory cacheability attribute: The memory region supports being
        /// configured as write combining.
        /// </summary>
        MEMORY_WC = 0x0000000000000002,
        /// <summary>
        /// Memory cacheability attribute: The memory region supports being
        /// configured as cacheable with a “write through” policy. Writes that
        /// hit in the cache will also be written to main memory.
        /// </summary>
        MEMORY_WT = 0x0000000000000004,
        /// <summary>
        /// Memory cacheability attribute: The memory region supports being
        /// configured as cacheable with a “write back” policy. Reads and writes
        /// that hit in the cache do not propagate to main memory. Dirty data is
        /// written back to main memory when a new cache line is allocated.
        /// </summary>
        MEMORY_WB = 0x0000000000000008,
        /// <summary>
        /// Memory cacheability attribute: The memory region supports being
        /// configured as not cacheable, exported, and supports the “fetch and
        /// add” semaphore mechanism. 
        /// </summary>
        MEMORY_UCE = 0x0000000000000010,
        /// <summary>
        /// Physical memory protection attribute: The memory region supports
        /// being configured as write-protected by system hardware.This is
        /// typically used as a cacheability attribute today.The memory region
        /// supports being configured as cacheable with a "write protected"
        /// policy.Reads come from cache lines when possible, and read misses
        /// cause cache fills. Writes are propagated to the system bus and cause
        /// corresponding cache lines on all processors on the bus to be
        /// invalidated.
        /// </summary>
        MEMORY_WP = 0x0000000000001000,
        /// <summary>
        /// Physical memory protection attribute: The memory region supports
        /// being configured as read-protected by system hardware.
        /// </summary>
        MEMORY_RP = 0x0000000000002000,
        /// <summary>
        /// Physical memory protection attribute: The memory region supports
        /// being configured so it is protected by system hardware from
        /// executing code.
        /// </summary>
        MEMORY_XP = 0x0000000000004000,
        /// <summary>
        /// Runtime memory attribute: The memory region refers to persistent
        /// memory
        /// </summary>
        MEMORY_NV = 0x0000000000008000,
        /// <summary>
        /// The memory region provides higher reliability relative to other
        /// memory in the system. If all memory has the same reliability, then
        /// this bit is not used.
        /// </summary>
        MEMORY_MORE_RELIABLE = 0x0000000000010000,
        /// <summary>
        /// Physical memory protection attribute: The memory region supports
        /// making this memory range read-only by system hardware.
        /// </summary>
        MEMORY_RO = 0x0000000000020000,
        /// <summary>
        /// Specific-purpose memory (SPM). The memory is earmarked for
        /// specific purposes such as for specific device drivers or applications.
        /// The SPM attribute serves as a hint to the OS to avoid allocating this
        /// memory for core OS data or code that can not be relocated.
        /// Prolonged use of this memory for purposes other than the intended
        /// purpose may result in suboptimal platform performance.
        /// </summary>
        MEMORY_SP = 0x0000000000040000,
        /// <summary>
        /// If this flag is set, the memory region is capable of being
        // protected with the CPU’s memory cryptographic capabilities.If this
        // flag is clear, the memory region is not capable of being protected
        // with the CPU’s memory cryptographic capabilities or the CPU does
        // not support CPU memory cryptographic capabilities.
        /// </summary>
        MEMORY_CPU_CRYPTO = 0x0000000000080000,
        /// <summary>
        /// Runtime memory attribute: The memory region needs to be given a
        /// virtual mapping by the operating system when
        /// SetVirtualAddressMap() is called (described in Section 8.4).
        /// </summary>
        MEMORY_RUNTIME = 0x8000000000000000,
    }
}
