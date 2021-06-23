using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class RegularFactory:IFactory
    {
        public ICreditCard CreateCard()
        {
            return new RegularCreditCard();
        }
    }
}
