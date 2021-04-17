using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    public class SingletonWithLazy
    {
        private static readonly Lazy<SingletonWithLazy> singletonLazyObj = new Lazy<SingletonWithLazy>(() => new SingletonWithLazy());

        private SingletonWithLazy() { }
        
        public static SingletonWithLazy SingletonLazyObj { 
            get { return singletonLazyObj.Value; }
        }

    }
}
