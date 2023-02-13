namespace System.Runtime.CompilerServices
{
    public static class RuntimeFeature
    {
        /// <summary>
        /// Indicates that this version of runtime supports default interface method implementations.
        /// </summary>
        public const string DefaultImplementationsOfInterfaces = nameof(DefaultImplementationsOfInterfaces);

        /// <summary>
        /// Indicates that this version of runtime supports the Unmanaged calling convention value.
        /// </summary>
        public const string UnmanagedSignatureCallingConvention = nameof(UnmanagedSignatureCallingConvention);

        /// <summary>
        /// Indicates that this version of runtime supports covariant returns in overrides of methods declared in classes.
        /// </summary>
        public const string CovariantReturnsOfClasses = nameof(CovariantReturnsOfClasses);

        /// <summary>
        /// Represents a runtime feature where types can define ref fields.
        /// </summary>
        public const string ByRefFields = nameof(ByRefFields);

        /// <summary>
        /// Indicates that this version of runtime supports virtual static members of interfaces.
        /// </summary>
        public const string VirtualStaticsInInterfaces = nameof(VirtualStaticsInInterfaces);

        /// <summary>
        /// Indicates that this version of runtime supports <see cref="System.IntPtr" /> and <see cref="System.UIntPtr" /> as numeric types.
        /// </summary>
        public const string NumericIntPtr = nameof(NumericIntPtr);

        /// <summary>
        /// Checks whether a certain feature is supported by the Runtime.
        /// </summary>
        public static bool IsSupported(string feature)
        {
            return feature switch
            {
                CovariantReturnsOfClasses or ByRefFields or UnmanagedSignatureCallingConvention or DefaultImplementationsOfInterfaces or VirtualStaticsInInterfaces or NumericIntPtr => true,
                _ => false,
            };
        }
    }
}
