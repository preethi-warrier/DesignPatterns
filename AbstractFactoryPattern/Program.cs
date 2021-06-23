using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard pCard = Factory.GetFactory(CardType.Platinum).CreateCard();
            ICreditCard rCard = Factory.GetFactory(CardType.Regular).CreateCard();

            Console.WriteLine(pCard.Type);
            Console.WriteLine(rCard.Type);
        }
    }
}
