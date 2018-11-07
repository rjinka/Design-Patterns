using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton Instance = new Singleton();
        private int numberofinstance = 0;

        private Singleton()
        {
            Console.WriteLine("Instantiating inside the private constructor.");
            numberofinstance++;
            Console.WriteLine("Number of Instances = {0}", numberofinstance);
        }

        public static Singleton GetInstance
        {
            get
            {
                Console.WriteLine("We already have an Instance, use it");
                return Instance;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tring to create first instance");
            Singleton FirstInstance = Singleton.GetInstance;
            Console.WriteLine("Tring to create second instance");
            Singleton SecondInstance = Singleton.GetInstance;
            if(FirstInstance == SecondInstance)
            {
                Console.WriteLine("only one instance exists.");
            }
            else
            {
                Console.WriteLine("Different instance exists.");
            }

            Console.ReadLine();
        }
    }
}
