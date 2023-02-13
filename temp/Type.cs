using System;
using System.Runtime.CompilerServices;

namespace System
{
    public abstract class Type
    {
        [Intrinsic]
        public static Type? GetTypeFromHandle(RuntimeTypeHandle handle)
            => handle.m_type;
    }

    internal sealed partial class RuntimeType
    {
        public Type UnderlyingSystemType => this;

        [Intrinsic]
        public static implicit operator Type(RuntimeType d)
        {
            return d;
        }

        public object Clone() => this;

        public override bool Equals(object? obj)
        {
            // ComObjects are identified by the instance of the Type object and not the TypeHandle.
            return obj == (object)this;
        }
    }
}
