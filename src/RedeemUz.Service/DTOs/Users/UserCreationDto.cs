namespace RedeemUz.Service.DTOs.Users
{
    public class UserCreationDto
    {
        public string Username { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Password { get; set; }
        public string TelegramId { get; set; } = string.Empty;
    }
}
