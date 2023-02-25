// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace System {
    // Because we have special type system support that says a boxed Nullable<T>
    // can be used where a boxed T is used, Nullable<T> can not implement any interfaces
    // at all (since T may not).
    //
    // Do NOT add any interfaces to Nullable!

    public partial struct Nullable<T> where T : struct {
        private readonly bool hasValue; // Do not rename (binary serialization)
        public T value; // Do not rename (binary serialization) or make readonly (can be mutated in ToString, etc.)

        public Nullable(T value) {
            this.value = value;
            hasValue = true;
        }

        public readonly bool HasValue {
            get => hasValue;
        }

        public readonly T Value {
            get {
                if (!hasValue) {
                    throw new InvalidOperationException();
                }
                return value;
            }
        }

        internal ref T GetRef() {
            unsafe {
                fixed (T* a = &value) {
                    return ref Unsafe.AsRef<T>(a);
                }
            }
        }


        public readonly T GetValueOrDefault() => value;

        public readonly T GetValueOrDefault(T defaultValue) =>
            hasValue ? value : defaultValue;

        public static implicit operator Nullable<T>(T value) => new Nullable<T>(value);

        public static explicit operator T(Nullable<T> value) => value!.Value;
    }

    public static class Nullable {
        // If the type provided is not a Nullable Type, return null.
        // Otherwise, return the underlying type of the Nullable type
        public static Type? GetUnderlyingType(Type nullableType) {
            if (nullableType == null) {
                throw new ArgumentNullException();
            }
            // This is necessary to handle types without reflection metadata
            var nullableEEType = nullableType.TypeHandle.ToEETypePtr();

            if (nullableEEType.IsGeneric) {
                if (nullableEEType.IsNullable) {
                    return new Type(new RuntimeTypeHandle(nullableEEType.NullableType.BaseType));
                }
            }
            return null;
        }

        /// <summary>
        /// Retrieves a readonly reference to the location in the <see cref="Nullable{T}"/> instance where the value is stored.
        /// </summary>
        /// <typeparam name="T">The underlying value type of the <see cref="Nullable{T}"/> generic type.</typeparam>
        /// <param name="nullable">The readonly reference to the input <see cref="Nullable{T}"/> value.</param>
        /// <returns>A readonly reference to the location where the instance's <typeparamref name="T"/> value is stored. If the instance's <see cref="Nullable{T}.HasValue"/> is false, the current value at that location may be the default value.</returns>
        /// <remarks>
        /// As the returned readonly reference refers to data that is stored in the input <paramref name="nullable"/> value, this method should only ever be
        /// called when the input reference points to a value with an actual location and not an "rvalue" (an expression that may appear on the right side but not left side of an assignment). That is, if this API is called and the input reference
        /// points to a value that is produced by the compiler as a defensive copy or a temporary copy, the behavior might not match the desired one.
        /// </remarks>
        public static ref T GetValueRefOrDefaultRef<T>(T? nullable) where T : struct {
            unsafe {
                return ref nullable.GetRef();
            }
        }
    }
}
