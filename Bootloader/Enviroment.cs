public static class Environment
{
    public const string NewLine = "\r\n";
    public static unsafe char* NewLinePtr
    {
        get
        {
            unsafe
            {
                fixed (char* c = NewLine)
                {
                    return c;
                }
            }
        }
    }
}
