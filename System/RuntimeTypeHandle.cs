// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Internal.Runtime;

using System.Diagnostics;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct RuntimeTypeHandle
    {
        private IntPtr _value;
        //
        // Caution: There can be and are multiple MethodTable for the "same" type (e.g. int[]). That means
        // you can't use the raw IntPtr value for comparisons.
        //

        internal RuntimeTypeHandle(EETypePtr pEEType)
            : this(pEEType.RawValue)
        {
        }

        private RuntimeTypeHandle(IntPtr value)
        {
            unsafe
            {
                _value = value;
            }
        }
        [Intrinsic]
        internal static unsafe IntPtr GetValueInternal(RuntimeTypeHandle handle)
        {
            return (IntPtr)handle.ToEETypePtr().ToPointer();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(RuntimeTypeHandle handle)
        {
            if (_value == handle._value)
            {
                return true;
            }
            else if (this.IsNull || handle.IsNull)
            {
                return false;
            }
            else
            {
                return RuntimeImports.AreTypesEquivalent(this.ToEETypePtr(), handle.ToEETypePtr());
            }
        }

        public static RuntimeTypeHandle FromIntPtr(IntPtr value) => new(value);

        public static IntPtr ToIntPtr(RuntimeTypeHandle value) => value.Value;

        public static bool operator ==(object? left, RuntimeTypeHandle right)
        {
            if (left is RuntimeTypeHandle)
                return right.Equals((RuntimeTypeHandle)left);
            return false;
        }

        public static bool operator ==(RuntimeTypeHandle left, object? right)
        {
            if (right is RuntimeTypeHandle)
                return left.Equals((RuntimeTypeHandle)right);
            return false;
        }

        public static bool operator !=(object? left, RuntimeTypeHandle right)
        {
            if (left is RuntimeTypeHandle)
                return !right.Equals((RuntimeTypeHandle)left);
            return true;
        }

        public static bool operator !=(RuntimeTypeHandle left, object? right)
        {
            if (right is RuntimeTypeHandle)
                return !left.Equals((RuntimeTypeHandle)right);
            return true;
        }

        public IntPtr Value => _value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal EETypePtr ToEETypePtr()
        {
            return new EETypePtr(_value);
        }

        internal bool IsNull
        {
            get
            {
                return _value == new IntPtr(0);
            }
        }

        internal IntPtr RawValue
        {
            get
            {
                return _value;
            }
        }
    }
}
