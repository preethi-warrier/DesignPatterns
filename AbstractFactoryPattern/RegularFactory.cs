using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class RegularFactory:Factory
    {
        public override ICreditCard CreateCard()
        {
            return new RegularCreditCard();
        }
    }
}
