using RedeemUz.Domain.Entities;

namespace Taxify.DataAccess.Contracts;

public interface IUnitOfWork:IDisposable
{
    IRepository<User> UserRepository { get; }

    ValueTask SaveAsync();
}