using System.Threading;

namespace SingletonLiveExample
{
    #region Basic Singleton (Not Thread-Safe)
    public class FingerprintSingletonBasic
    {
        private static FingerprintSingletonBasic _instance;

        // Private constructor to prevent anyone from creating a new instance
        private FingerprintSingletonBasic()
        {
        }

        // Provides a global access point to the single instance
        public static FingerprintSingletonBasic GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FingerprintSingletonBasic();
            }
            return _instance;
        }

        // Note: This version is NOT thread-safe
        // If you have a multi-threaded program (e.g., Web App or Console App with multiple threads),
        // Thread1 and Thread2 could enter the 'if' condition at the same time,
        // resulting in multiple instances being created.
        //❌ النتيجة: Singleton مش فعلي → بيضيع الهدف منه
    }
    #endregion

    #region Enhanced Singleton (Thread-Safe)
    public class FingerprintSingletonThreadSafe
    {
        private static FingerprintSingletonThreadSafe _instance;
        private static readonly object _lock = new object();

        private FingerprintSingletonThreadSafe() { }

        public static FingerprintSingletonThreadSafe GetInstance()
        {
            // Lock prevents other threads from entering this block simultaneously
            lock (_lock)// أي Thread يدخل جوه القفل، أي Thread تاني لازم يستنى لغاية ما الأول يخلص
            {
                if (_instance == null)
                {
                    _instance = new FingerprintSingletonThreadSafe();
                }
                return _instance;
            }
        }
    }
    #endregion
}
