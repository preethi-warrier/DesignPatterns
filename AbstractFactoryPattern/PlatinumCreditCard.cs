using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class PlatinumCreditCard :ICreditCard
    {
        public PlatinumCreditCard()
        {
            CreditLimit = 70000;
            AnnualCharge = 2000;
            Type = "Platinum Credit Card";
        }

        public int CreditLimit { get; private set; }
        public int AnnualCharge { get; private set; }
        public string Type { get; private set; }
    }
}
