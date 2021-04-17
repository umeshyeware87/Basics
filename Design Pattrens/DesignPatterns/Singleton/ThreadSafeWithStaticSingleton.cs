using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class ThreadSafeWithStaticSingleton
    {
        private static readonly ThreadSafeWithStaticSingleton tsWSSingleton = new ThreadSafeWithStaticSingleton();

        //Explicit static constructor to tell C# compilter not to mark type as beforefieldinit
        static ThreadSafeWithStaticSingleton() { }
        

        private ThreadSafeWithStaticSingleton() { }
        

        public static ThreadSafeWithStaticSingleton TSWSSingleton
        {
            get { return tsWSSingleton; }
        }
    }
}
