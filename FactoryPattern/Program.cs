using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard pCard = new PlatinumFactory().CreateCard();
            ICreditCard rCard = new RegularFactory().CreateCard();

            Console.WriteLine(pCard.Type);
            Console.WriteLine(rCard.Type);
        }
    }
}
