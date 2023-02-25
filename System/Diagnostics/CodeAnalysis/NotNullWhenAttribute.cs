namespace System.Diagnostics.CodeAnalysis {
    /// <summary>Specifies that when a method returns <see cref="ReturnValue"/>, the parameter will not be null even if the corresponding type allows it.</summary>
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    public sealed class NotNullWhenAttribute : Attribute {
        /// <summary>Initializes the attribute with the specified return _value condition.</summary>
        /// <param name="returnValue">
        /// The return _value condition. If the method returns this _value, the associated parameter will not be null.
        /// </param>
        public NotNullWhenAttribute(bool returnValue) => ReturnValue = returnValue;

        /// <summary>Gets the return _value condition.</summary>
        public bool ReturnValue { get; }
    }
}