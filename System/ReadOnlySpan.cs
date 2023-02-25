// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Runtime.CompilerServices;

namespace System {
    /// <summary>
    /// ReadOnlySpan represents a contiguous region of arbitrary memory. Unlike arrays, it can point to either managed
    /// or native memory, or to memory allocated on the stack. It is type- and memory-safe.
    /// </summary>
    public readonly ref struct ReadOnlySpan<T> {
        /// <summary>A byref or a native ptr.</summary>
        internal readonly ref T _reference;
        /// <summary>The number of elements this ReadOnlySpan contains.</summary>
        private readonly int _length;

        /// <summary>
        /// Creates a new read-only span over the entirety of the target array.
        /// </summary>
        /// <param name="array">The target array.</param>
        /// <remarks>Returns default when <paramref name="array"/> is null.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan(T[]? array) {
            if (array == null) {
                this = default;
                return; // returns default
            }
            unsafe {
                _reference = ref Unsafe.AsRef<T>((T*)&array);
            }
            _length = array.Length;
        }

        /// <summary>
        /// Creates a new read-only span over the portion of the target array beginning
        /// at 'start' index and ending at 'end' index (exclusive).
        /// </summary>
        /// <param name="array">The target array.</param>
        /// <param name="start">The index at which to begin the read-only span.</param>
        /// <param name="length">The number of items in the read-only span.</param>
        /// <remarks>Returns default when <paramref name="array"/> is null.</remarks>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the specified <paramref name="start"/> or end index is not in the range (&lt;0 or &gt;Length).
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan(T[]? array, int start, int length) {
            if (array == null) {
                this = default;
                return; // returns default
            }
#if TARGET_64BIT
            // See comment in Span<T>.Slice for how this works.
            if ((uint)start + (ulong)(uint)length > (uint)array.Length) {
                this = default;
                return;
            }
#else
            if ((uint)start > (uint)array.Length || (uint)length > (uint)(array.Length - start)){
                this = default;
                return;
            }
#endif
            unsafe {
                _reference = ref Unsafe.Add(ref Unsafe.AsRef<T>((T*)&array), (nint)(uint)start);
            }
            _length = length;
        }

        /// <summary>
        /// Creates a new read-only span over the target unmanaged buffer.  Clearly this
        /// is quite dangerous, because we are creating arbitrarily typed T's
        /// out of a void*-typed block of memory.  And the length is not checked.
        /// But if this creation is correct, then all subsequent uses are correct.
        /// </summary>
        /// <param name="pointer">An unmanaged pointer to memory.</param>
        /// <param name="length">The number of <typeparamref name="T"/> elements the memory contains.</param>
        /// <exception cref="System.ArgumentException">
        /// Thrown when <typeparamref name="T"/> is reference type or contains pointers and hence cannot be stored in unmanaged memory.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the specified <paramref name="length"/> is negative.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ReadOnlySpan(void* pointer, int length) {
            _reference = ref Unsafe.As<byte, T>(ref *(byte*)pointer);
            _length = length;
        }

        /// <summary>Creates a new <see cref="ReadOnlySpan{T}"/> of length 1 around the specified reference.</summary>
        /// <param name="reference">A reference to data.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan(in T reference) {
            _reference = ref Unsafe.AsRef(in reference);
            _length = 1;
        }

        // Constructor for internal use only. It is not safe to expose publicly, and is instead exposed via the unsafe MemoryMarshal.CreateReadOnlySpan.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal ReadOnlySpan(ref T reference, int length) {
            _reference = ref reference;
            _length = length;
        }

        /// <summary>
        /// Returns the specified element of the read-only span.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="System.IndexOutOfRangeException">
        /// Thrown when index less than 0 or index greater than or equal to Length
        /// </exception>
        public ref readonly T this[int index] {
            [Intrinsic]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                if ((uint)index >= (uint)_length) return ref Unsafe.NullRef<T>();
                return ref Unsafe.Add(ref _reference, (nint)(uint)index /* force zero-extension */);
            }
        }

        /// <summary>
        /// The number of items in the read-only span.
        /// </summary>
        public int Length {
            [Intrinsic]
            get => _length;
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="ReadOnlySpan{T}"/> is empty.
        /// </summary>
        /// <value><see langword="true"/> if this span is empty; otherwise, <see langword="false"/>.</value>
        public bool IsEmpty {
            get => _length == 0;
        }

        /// <summary>
        /// Returns false if left and right point at the same memory and have the same length.  Note that
        /// this does *not* check to see if the *contents* are equal.
        /// </summary>
        public static bool operator !=(ReadOnlySpan<T> left, ReadOnlySpan<T> right) => !(left == right);

        /// <summary>
        /// Defines an implicit conversion of an array to a <see cref="ReadOnlySpan{T}"/>
        /// </summary>
        public static implicit operator ReadOnlySpan<T>(T[]? array) => new(array);

        /// <summary>
        /// Returns a 0-length read-only span whose base is the null pointer.
        /// </summary>
        public static ReadOnlySpan<T> Empty => default;

        /// <summary>Gets an enumerator for this span.</summary>
        public Enumerator GetEnumerator() => new(this);

        /// <summary>Enumerates the elements of a <see cref="ReadOnlySpan{T}"/>.</summary>
        public ref struct Enumerator {
            /// <summary>The span being enumerated.</summary>
            private readonly ReadOnlySpan<T> _span;
            /// <summary>The next index to yield.</summary>
            private int _index;

            /// <summary>Initialize the enumerator.</summary>
            /// <param name="span">The span to enumerate.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal Enumerator(ReadOnlySpan<T> span) {
                _span = span;
                _index = -1;
            }

            /// <summary>Advances the enumerator to the next element of the span.</summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool MoveNext() {
                int index = _index + 1;
                if (index < _span.Length) {
                    _index = index;
                    return true;
                }

                return false;
            }

            /// <summary>Gets the element at the current position of the enumerator.</summary>
            public ref readonly T Current {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref _span[_index];
            }
        }

        /// <summary>
        /// Returns a reference to the 0th element of the Span. If the Span is empty, returns null reference.
        /// It can be used for pinning and is required to support the use of span within a fixed statement.
        /// </summary>
        public ref readonly T GetPinnableReference() {
            // Ensure that the native code has just one forward branch that is predicted-not-taken.
            ref T ret = ref Unsafe.NullRef<T>();
            if (_length != 0) ret = ref _reference;
            return ref ret;
        }

        /// <summary>
        /// Returns true if left and right point at the same memory and have the same length.  Note that
        /// this does *not* check to see if the *contents* are equal.
        /// </summary>
        public static bool operator ==(ReadOnlySpan<T> left, ReadOnlySpan<T> right) =>
            left._length == right._length &&
            Unsafe.AreSame<T>(ref left._reference, ref right._reference);


        /// <summary>
        /// Forms a slice out of the given read-only span, beginning at 'start'.
        /// </summary>
        /// <param name="start">The index at which to begin this slice.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the specified <paramref name="start"/> index is not in range (&lt;0 or &gt;Length).
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T> Slice(int start) {
            if ((uint)start > (uint)_length) return null;

            return new ReadOnlySpan<T>(ref Unsafe.Add(ref _reference, (nint)(uint)start /* force zero-extension */), _length - start);
        }

        /// <summary>
        /// Forms a slice out of the given read-only span, beginning at 'start', of given length
        /// </summary>
        /// <param name="start">The index at which to begin this slice.</param>
        /// <param name="length">The desired length for the slice (exclusive).</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the specified <paramref name="start"/> or end index is not in range (&lt;0 or &gt;Length).
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T> Slice(int start, int length) {
#if TARGET_64BIT
            // See comment in Span<T>.Slice for how this works.
            if ((uint)start + (ulong)(uint)length > (uint)_length) return null;
#else
            if ((uint)start > (uint)_length || (uint)length > (uint)(_length - start)) return null;
#endif

            return new ReadOnlySpan<T>(ref Unsafe.Add(ref _reference, (nint)(uint)start /* force zero-extension */), length);
        }

        /// <summary>
        /// Copies the contents of this read-only span into a new array.  This heap
        /// allocates, so should generally be avoided, however it is sometimes
        /// necessary to bridge the gap with APIs written in terms of arrays.
        /// </summary>
        public T[] ToArray() {
            if (_length == 0)
                return Array.Empty<T>();

            var destination = new T[_length];

            for (int i = 0; i < _length; i++) {
                destination[i] = this[i];
            }
            return destination;
        }
    }
}
