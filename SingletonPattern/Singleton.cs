using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static object padlock = new object();
        Singleton()
        {
            //private constructors prevent the class from
            //being inherited or instantiated.
        }

        public static Singleton GetInstance()
        {
            lock (padlock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
            return _instance;
        }

        public void Print()
        {
            Console.WriteLine("I am a Singleton class!");
        }
    }
}
