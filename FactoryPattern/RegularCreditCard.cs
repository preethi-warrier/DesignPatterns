using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class RegularCreditCard : ICreditCard
    {
        public RegularCreditCard()
        {
            CreditLimit = 35000;
            AnnualCharge = 1000;
            Type = "Regular Credit Card";
        }

        public int CreditLimit { get; private set; }
        public int AnnualCharge { get; private set; }
        public string Type { get; private set; }
    }
}
