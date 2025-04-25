using Microsoft.EntityFrameworkCore;
using RedeemUz.Domain.Entities;
using System.Net.Mail;

namespace RedeemUz.DataAccess.Contexts;

public class RedeemUzDbContext : DbContext
{
    public RedeemUzDbContext(DbContextOptions<RedeemUzDbContext> options) : base(options)
    { }

    public DbSet<User> Users { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<PromoCode> PromoCodes { get; set; }
    public DbSet<RedeemCode> RedeemCodes { get; set; }
    public DbSet<UC> UCs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new User
        {
            Id = 1,
            Username = "Jahongir",
            UpdatedAt = DateTime.UtcNow,
            TelegramId= "12345",
            Balance = 0,
            CreatedAt = DateTime.Now,
            IsBlocked = false,
            IsDeleted = false,
            Password = BCrypt.Net.BCrypt.HashPassword(inputKey: "12345"),
            Phone = "+998900957074",


        });
    }
}