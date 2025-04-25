using Taxify.Domain.Commons;

namespace RedeemUz.Domain.Entities
{
    public class User : Auditable
    {
        public string Username { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Password { get; set; }
        public bool IsBlocked { get; set; } = false;
        public string TelegramId { get; set; } = string.Empty;
        public double Balance { get; set; } = 0.00;
    }
}
