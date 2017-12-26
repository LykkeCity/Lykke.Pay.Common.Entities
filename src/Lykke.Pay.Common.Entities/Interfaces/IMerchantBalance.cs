using System.Collections.Generic;

namespace Lykke.Pay.Common.Entities.Interfaces
{
    public interface IMerchantBalance
    {
        IEnumerable<IMerchantAssertBalance> Asserts { get; set; }
    }
}