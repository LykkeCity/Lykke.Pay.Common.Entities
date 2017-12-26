using System;
using System.Collections.Generic;
using System.Text;
using Lykke.Pay.Common.Entities.Interfaces;

namespace Lykke.Pay.Common.Entities.Entities
{
    public class MerchantStaff : IMerchantStaff
    {
        public MerchantStaff()
        {
            
        }

        public MerchantStaff(IMerchantStaff merchantStaff)
        {

            MerchantId = merchantStaff.MerchantId;
            MerchantStaffEmail = merchantStaff.MerchantStaffEmail;
            MerchantStaffFirstName = merchantStaff.MerchantStaffFirstName;
            MerchantStaffLastName = merchantStaff.MerchantStaffLastName;
            MerchantStaffPassword = merchantStaff.MerchantStaffPassword;
            LwId = merchantStaff.LwId;
        }

        public string MerchantId { get; set; }
        public string MerchantStaffEmail { get; set; }
        public string MerchantStaffFirstName { get; set; }
        public string MerchantStaffLastName { get; set; }
        public string MerchantStaffPassword { get; set; }
        public string LwId { get; set; }
    }
}
