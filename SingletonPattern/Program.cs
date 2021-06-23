using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton si = Singleton.GetInstance();
            si.Print();
            Singleton si1 = Singleton.GetInstance();
            if(si == si1)
            {
                Console.WriteLine("Only a single instance is created");
            }
        }
    }
}
