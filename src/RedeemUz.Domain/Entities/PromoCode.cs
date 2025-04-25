using Taxify.Domain.Commons;

namespace RedeemUz.Domain.Entities
{
    public class PromoCode : Auditable
    {
        public string Code { get; set; }
        public int DisCountPercent { get; set; }
        public int MaxUsage { get; set; }
        public int UsedCount { get; set; }
        public DateTime ExpiredAt { get; set; }
    }
}
