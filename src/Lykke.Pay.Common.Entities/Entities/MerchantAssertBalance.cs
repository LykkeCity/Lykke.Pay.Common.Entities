using Lykke.Pay.Common.Entities.Interfaces;

namespace Lykke.Pay.Common.Entities.Entities
{
    public class MerchantAssertBalance : IMerchantAssertBalance
    {
        public MerchantAssertBalance(IMerchantAssertBalance assertBalance)
        {
            Assert = assertBalance.Assert;
            Value = assertBalance.Value;
        }
        public string Assert { get; set; }
        public double Value { get; set; }
    }
}