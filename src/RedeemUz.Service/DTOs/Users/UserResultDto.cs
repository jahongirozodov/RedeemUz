namespace RedeemUz.Service.DTOs.Users
{
    public class UserResultDto
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; } 
        public bool IsBlocked { get; set; } 
        public string TelegramId { get; set; } 
        public double Balance { get; set; } = 0.00;
    }
}
