using System;
using System.Collections.Generic;
using System.Text;


namespace Lykke.Pay.Common.Entities.Interfaces
{
    public interface IInvoiceRequest
    {
        string MerchantId {get; set; }
        string MerchantStaffId { get; set; }
        string InvoiceNumber { get; set; }
        DateTime Date { get; set; }
        string ClientName { get; set; }
        string ClientEmail { get; set; }
        double Amount { get; set; }
        int Status { get; set; }
        DateTime PaidDueDate { get; set; }
        string RequestId { get; set; }
    }
}
