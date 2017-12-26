using System;
using System.Text;

namespace Lykke.Pay.Common.Entities.Interfaces
{
    public interface IMerchantStaff
    {
        string MerchantId { get; set; }
        string MerchantStaffEmail { get; set; }
        string MerchantStaffFirstName { get; set; }
        string MerchantStaffLastName { get; set; }
        string MerchantStaffPassword { get; set; }

    }
}

