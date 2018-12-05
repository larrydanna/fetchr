namespace fetchr.GenericPatterns
{
    public abstract class Singleton<T, TI> where T : class, TI, new() where TI : class
    {
        private static TI _instance;

        // ReSharper disable once StaticMemberInGenericType
        private static readonly object LockObj = new object();

        public static TI Instance
        {
            get
            {
                lock (LockObj)
                {
                    // ReSharper disable once ConvertIfStatementToNullCoalescingExpression
                    if (_instance == null)
                    {
                        _instance = new T();
                    }
                    return _instance;

                }
            }
            set { _instance = value; }
        }
    }
}