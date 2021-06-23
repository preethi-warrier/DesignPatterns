using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    //concrete Factory
    public class PlatinumFactory : Factory
    {
        public override ICreditCard CreateCard()
        {
            return new PlatinumCreditCard();
        }
    }
}
