namespace AbstractFactoryPattern
{
    //Product
    public interface ICreditCard
    {
        int AnnualCharge { get; }
        int CreditLimit { get; }
        string Type { get; }
    }
}