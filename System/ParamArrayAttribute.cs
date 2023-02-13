namespace System
{
    [AttributeUsage(AttributeTargets.Parameter, Inherited = true, AllowMultiple = false)]
    public class ParamArrayAttribute : Attribute
    {
        public ParamArrayAttribute()
        {
        }
    }
}
