namespace Lykke.Pay.Common.Entities.Interfaces
{
    public interface IMerchantAssertBalance
    {
        string Assert { get; set; }
        double Value { get; set; }
    }
}