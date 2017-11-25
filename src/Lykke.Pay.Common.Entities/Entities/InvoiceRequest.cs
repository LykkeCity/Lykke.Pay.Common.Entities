using System;
using Lykke.Pay.Common.Entities.Interfaces;

namespace Lykke.Pay.Common.Entities.Entities
{
    public class InvoiceRequest : IInvoiceRequest
    {
        public string MerchantId { get; set; }
        public string MerchantStaffId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public double Amount { get; set; }
        public int Status { get; set; }
        public DateTime PaidDueDate { get; set; }
        public string RequestId { get; set; }
    }
}
