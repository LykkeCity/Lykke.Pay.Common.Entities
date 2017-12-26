using System.Collections.Generic;
using System.Linq;
using Lykke.Pay.Common.Entities.Interfaces;

namespace Lykke.Pay.Common.Entities.Entities
{
    public class MerchantBalance : IMerchantBalance
    {
        public IEnumerable<IMerchantAssertBalance> Asserts { get; set; }

        public MerchantBalance()
        {
            
        }
        public MerchantBalance(IMerchantBalance balance)
        {
            Asserts = new List<IMerchantAssertBalance>(from a in balance.Asserts select a);
        }
    }
}