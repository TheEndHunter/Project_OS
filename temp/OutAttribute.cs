namespace System.Runtime.InteropServices
{
    // Not used in Redhawk. Only here as C# compiler requires it
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    internal sealed class OutAttribute : Attribute
    {
        public OutAttribute()
        {
        }
    }
}
