using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class ThreadSafeDoubleCheckSingleton
    {
        private static ThreadSafeDoubleCheckSingleton tsdcSingletonObj = null;
        private static readonly object padLock = new object();

        private ThreadSafeDoubleCheckSingleton() { }
        

        public static ThreadSafeDoubleCheckSingleton TSDCSingletonObj
        {
            get
            {
                if(tsdcSingletonObj == null)
                {
                    lock(padLock)
                    {
                        if(tsdcSingletonObj == null)
                        {
                            tsdcSingletonObj = new ThreadSafeDoubleCheckSingleton();
                        }
                    }
                }
                return tsdcSingletonObj;
            }
        }
    }
}
