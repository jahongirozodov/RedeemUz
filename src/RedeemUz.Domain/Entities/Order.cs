using RedeemUz.Domain.Enums;
using Taxify.Domain.Commons;

namespace RedeemUz.Domain.Entities
{
    public class Order : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }

        public long UcId { get; set; }
        public UC UC { get; set; }

        public long? RedeemCodeId { get; set; } = null; 
        public RedeemCode RedeemCode { get; set; }
        
        public string PubgId { get; set; }
        public PaymentMethod paymentMethod { get; set; }
    }
}
