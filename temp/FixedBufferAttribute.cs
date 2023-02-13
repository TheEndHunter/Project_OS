// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Runtime.CompilerServices
{
#pragma warning disable CA1018 // Mark attributes with AttributeUsageAttribute
    internal sealed unsafe class FixedBufferAttribute : Attribute
#pragma warning restore CA1018 // Mark attributes with AttributeUsageAttribute
    {
        public FixedBufferAttribute(Type elementType, int length)
        {
        }
    }
}
