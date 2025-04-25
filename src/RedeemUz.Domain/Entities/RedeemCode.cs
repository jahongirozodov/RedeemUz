using Taxify.Domain.Commons;

namespace RedeemUz.Domain.Entities
{
    public class RedeemCode : Auditable
    {
        public string Code { get; set; }
        public int UcAmount { get; set; }
        public double Price { get; set; }
        public bool IsUsed { get; set; } = false;
        
        public DateTime? UsedAt { get; set; } = null;
    }
}
