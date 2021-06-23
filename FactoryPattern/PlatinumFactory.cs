using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    //concrete Factory
    public class PlatinumFactory : IFactory
    {
        public ICreditCard CreateCard()
        {
            return new PlatinumCreditCard();
        }
    }
}
