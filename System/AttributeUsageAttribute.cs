namespace System {
#pragma warning disable CA1018 // Mark attributes with AttributeUsageAttribute
    public sealed class AttributeUsageAttribute : Attribute
#pragma warning restore CA1018 // Mark attributes with AttributeUsageAttribute
    {
        public AttributeUsageAttribute(AttributeTargets validOn) { }
        public bool AllowMultiple { get; set; }
        public bool Inherited { get; set; }
    }
}
