using System;
using System.Runtime.CompilerServices;

namespace System {
    public class Type {
        private readonly RuntimeTypeHandle _typeHandle;

        internal Type(RuntimeTypeHandle typeHandle) {
            _typeHandle = typeHandle;
        }

        public RuntimeTypeHandle TypeHandle => _typeHandle;

        [Intrinsic]
        public static bool operator ==(Type left, Type right) {
            return RuntimeTypeHandle.GetValueInternal(left._typeHandle) == RuntimeTypeHandle.GetValueInternal(right._typeHandle);
        }

        [Intrinsic]
        public static bool operator !=(Type left, Type right) => !(left == right);

    }
}
