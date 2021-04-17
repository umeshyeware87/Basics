using System;

namespace DesignPatterns.Structural
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool continueFlag = true;

            do
            {
                Console.WriteLine("1. Singleton");
                Console.WriteLine("2. Abstract Factory");
                Console.WriteLine("3. Factory Method");
                Console.Write("Please select pattern id: ");
                int patternID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                runDesignPatterns(patternID);
                Console.WriteLine("-------------------------------------");

                Console.Write("Do you want to contine (Y/N)? ");
                continueFlag = Console.ReadLine().ToUpper() == "Y";


            } while (continueFlag);
        }

        private static void runDesignPatterns(int patternID)
        {
            switch (patternID)
            {
                case 1:
                    SimpleSingleton ssObj1 = SimpleSingleton.SingletonObj;
                    SimpleSingleton ssObj2 = SimpleSingleton.SingletonObj;
                    Console.WriteLine($"Simple singleton objects are {(ssObj1.Equals(ssObj2) ? "equal" : "not equal")}");

                    ThreadSafeSimpleSingleton tssObj1 = ThreadSafeSimpleSingleton.TSSSingletonObj;
                    ThreadSafeSimpleSingleton tssObj2 = ThreadSafeSimpleSingleton.TSSSingletonObj;
                    Console.WriteLine($"Thread safe singleton objects are {(tssObj1.Equals(tssObj2) ? "equal" : "not equal")}");

                    ThreadSafeDoubleCheckSingleton tsdcsObj1 = ThreadSafeDoubleCheckSingleton.TSDCSingletonObj;
                    ThreadSafeDoubleCheckSingleton tsdcsObj2 = ThreadSafeDoubleCheckSingleton.TSDCSingletonObj;
                    Console.WriteLine($"Thread safe with double check singleton objects are {(tsdcsObj1.Equals(tsdcsObj2) ? "equal" : "not equal")}");

                    ThreadSafeWithStaticSingleton tsssObj1 = ThreadSafeWithStaticSingleton.TSWSSingleton;
                    ThreadSafeWithStaticSingleton tsssObj2 = ThreadSafeWithStaticSingleton.TSWSSingleton;
                    Console.WriteLine($"Thread safe with static singleton objects are {(tsssObj1.Equals(tsssObj2) ? "equal" : "not equal")}");

                    SingletonWithLazy lsObj1 = SingletonWithLazy.SingletonLazyObj;
                    SingletonWithLazy lsObj2 = SingletonWithLazy.SingletonLazyObj;
                    Console.WriteLine($"Singleton objects with C# Lazy are {(lsObj1.Equals(lsObj2) ? "equal" : "not equal")}");

                    break;

                default:
                    break;
            }
        }
    }
}
