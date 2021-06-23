namespace AbstractFactoryPattern
{
    public enum CardType
    {
        Platinum,
        Regular
    }
    //Factory
    public abstract class Factory
    {
        public abstract ICreditCard CreateCard();
        public static Factory GetFactory(CardType type)
        {
            if(type == CardType.Platinum)
            {
                return new PlatinumFactory();
            }
            if (type == CardType.Regular)
            {
                return new RegularFactory();
            }
            return null;
        }
    }
}