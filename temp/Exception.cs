// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System
{
    public abstract class Exception
    {
        private readonly string _exceptionString = string.Empty;

        public Exception() { }

        public Exception(string str)
        {
            _exceptionString = str;
        }
    }

    internal sealed class SerializationException : Exception
    {
        public SerializationException()
        {
        }

        public SerializationException(string str) : base(str)
        {
        }
    }

    internal sealed class ObjectDisposedException : Exception
    {
        public ObjectDisposedException()
        {
        }

        public ObjectDisposedException(string str) : base(str)
        {
        }
    }

    internal sealed class RankException : Exception
    {
        public RankException()
        {
        }

        public RankException(string str) : base(str)
        {
        }
    }

    internal sealed class FormatException : Exception
    {
        public FormatException()
        {
        }

        public FormatException(string str) : base(str)
        {
        }
    }
    internal sealed class KeyNotFoundException : Exception
    {
        public KeyNotFoundException()
        {
        }

        public KeyNotFoundException(string str) : base(str)
        {
        }
    }
    internal sealed class EndOfStreamException : Exception
    {
        public EndOfStreamException()
        {
        }

        public EndOfStreamException(string str) : base(str)
        {

        }
    }
    internal sealed class AggregateException : Exception
    {
        public AggregateException()
        {
        }

        public AggregateException(string str) : base(str)
        {
        }
    }

    internal sealed class ApplicationException : Exception
    {
        public ApplicationException()
        {
        }

        public ApplicationException(string str) : base(str)
        {
        }
    }
    internal sealed class ArgumentException : Exception
    {
        public ArgumentException() { }
        public ArgumentException(string str) : base(str) { }
    }

    internal sealed class AccessViolationException : Exception
    {
        public AccessViolationException() { }
        public AccessViolationException(string str) : base(str) { }
    }

    internal sealed class NullReferenceException : Exception
    {
        public NullReferenceException() { }
        public NullReferenceException(string str) : base(str) { }
    }

    internal sealed class InvalidOperationException : Exception
    {
        public InvalidOperationException() { }
        public InvalidOperationException(string str) : base(str) { }
    }

    internal sealed class ArgumentOutOfRangeException : Exception
    {
        public ArgumentOutOfRangeException() { }
        public ArgumentOutOfRangeException(string str) : base(str) { }

        internal static void ThrowIfGreaterThan(int scale, int v)
        {
            if (scale > v)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        internal static void ThrowIfGreaterThan(long scale, long v)
        {
            if (scale > v)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        internal static void ThrowIfGreaterThan(uint scale, uint v)
        {
            if (scale > v)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        internal static void ThrowIfGreaterThan(ulong scale, ulong v)
        {
            if (scale > v)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        internal static void ThrowIfGreaterThanOrEqual(float nearPlaneDistance, float farPlaneDistance)
        {
            if (nearPlaneDistance >= farPlaneDistance) throw new ArgumentOutOfRangeException("near plane is further out than the far plane");
        }

        internal static void ThrowIfLessThanOrEqual(float nearPlaneDistance, float v)
        {
            if (nearPlaneDistance >= v) throw new ArgumentOutOfRangeException("near plane less than required minimum value");
        }
    }

    internal sealed class IndexOutOfRangeException : Exception
    {
        public IndexOutOfRangeException() { }
        public IndexOutOfRangeException(string str) : base(str) { }
    }

    internal sealed class ArgumentNullException : Exception
    {
        public ArgumentNullException() { }
        public ArgumentNullException(string str) : base(str) { }

        public static void ThrowIfNull(object? val)
        {
            if (val is null)
            {
                throw new ArgumentNullException("Value is Null");
            }
        }
    }

    internal sealed class NotImplementedException : Exception
    {
        public NotImplementedException() { }
        public NotImplementedException(string str) : base(str) { }
    }

    internal sealed class NotSupportedException : Exception
    {
        public NotSupportedException() { }
        public NotSupportedException(string str) : base(str) { }
    }

    internal sealed class PlatformNotSupportedException : Exception
    {
        public PlatformNotSupportedException() { }
        public PlatformNotSupportedException(string str) : base(str) { }
    }

    internal sealed class InvalidCastException : Exception
    {
        public InvalidCastException() { }
        public InvalidCastException(string str) : base(str) { }
    }

    internal sealed class ArrayTypeMismatchException : Exception
    {
        public ArrayTypeMismatchException() { }
        public ArrayTypeMismatchException(string str) : base(str) { }
    }

    internal sealed class OverflowException : Exception
    {
        public OverflowException() { }
        public OverflowException(string str) : base(str) { }
    }

    internal sealed class ArithmeticException : Exception
    {
        public ArithmeticException() { }
        public ArithmeticException(string str) : base(str) { }
    }

    internal sealed class DivideByZeroException : Exception
    {
        public DivideByZeroException() { }
        public DivideByZeroException(string str) : base(str) { }
    }

    internal class OutOfMemoryException : Exception
    {
        public OutOfMemoryException() { }
        public OutOfMemoryException(string str) : base(str) { }
    }
}
