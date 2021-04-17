using System;

namespace DesignPatterns.Structural
{
    public sealed class SimpleSingleton
    {
        private static SimpleSingleton singletonObj = null;

        private SimpleSingleton()
        {

        }

        public static SimpleSingleton SingletonObj
        {
            get
            {
                if (singletonObj == null)
                {
                    singletonObj = new SimpleSingleton();
                }

                return singletonObj;
            }
        }

    }
    
}
