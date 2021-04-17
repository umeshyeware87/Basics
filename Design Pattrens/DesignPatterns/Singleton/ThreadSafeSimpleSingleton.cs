using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class ThreadSafeSimpleSingleton
    {
        private static ThreadSafeSimpleSingleton tssSingletonObj = null;
        private static readonly object padLock = new object(); 

        private ThreadSafeSimpleSingleton() { }
        

        public static ThreadSafeSimpleSingleton TSSSingletonObj
        {
            get
            {
                lock(padLock) {
                    if(tssSingletonObj == null)
                    {
                        tssSingletonObj = new ThreadSafeSimpleSingleton();
                    }
                }

                return tssSingletonObj;
            }
        }
    }
}
