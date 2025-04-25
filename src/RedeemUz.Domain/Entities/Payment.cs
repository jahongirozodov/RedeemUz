using RedeemUz.Domain.Enums;
using Taxify.Domain.Commons;

namespace RedeemUz.Domain.Entities
{
    public class Payment : Auditable
    {
        public Provider Provider { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        public string TransactionId { get; set; }
        
        public double Amount { get; set; }
        public DateTime PaidAt { get; set; }
    }
}
