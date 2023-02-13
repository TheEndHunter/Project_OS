namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
    public sealed class StructLayoutAttribute : Attribute
    {
        public StructLayoutAttribute(LayoutKind layoutKind)
        {
            LayoutKind = layoutKind;
        }

        // These fields are expected by C# compiler,
        // so just disable the 'unused' warning
#pragma warning disable 649
        public LayoutKind LayoutKind;
        public CharSet CharSet;
        public int Size;
        public int Pack;
    }
}
