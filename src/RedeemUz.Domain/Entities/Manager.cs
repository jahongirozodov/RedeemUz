using RedeemUz.Domain.Enums;
using Taxify.Domain.Commons;

namespace RedeemUz.Domain.Entities
{
    public class Manager : Auditable
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
