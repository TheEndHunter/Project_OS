namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>Specifies that the method will not return if the associated Boolean parameter is passed the specified _value.</summary>
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    public sealed class DoesNotReturnIfAttribute : Attribute
    {
        /// <summary>Initializes the attribute with the specified parameter _value.</summary>
        /// <param name="parameterValue">
        /// The condition parameter _value. Code after the method will be considered unreachable by diagnostics if the argument to
        /// the associated parameter matches this _value.
        /// </param>
        public DoesNotReturnIfAttribute(bool parameterValue) => ParameterValue = parameterValue;

        /// <summary>Gets the condition parameter _value.</summary>
        public bool ParameterValue { get; }
    }
}