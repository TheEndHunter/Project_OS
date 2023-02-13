namespace System.Runtime.InteropServices
{
    /// <summary>
    /// Provides an equivalent to <see cref="UnmanagedCallersOnlyAttribute"/> for native
    /// functions declared in .NET.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class UnmanagedCallConvAttribute : Attribute
    {
        public UnmanagedCallConvAttribute(Type[]? callConvs = null)
        {
            CallConvs = callConvs;
        }

        /// <summary>
        /// Types indicating calling conventions for the unmanaged target.
        /// </summary>
        /// <remarks>
        /// If <c>null</c>, the semantics are identical to <c>CallingConvention.Winapi</c>.
        /// </remarks>
        public Type[]? CallConvs;
    }
}
