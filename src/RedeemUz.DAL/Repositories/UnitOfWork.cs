using RedeemUz.DataAccess.Contexts;
using RedeemUz.Domain.Entities;
using Taxify.DataAccess.Contracts;

namespace Taxify.DataAccess.Repositories;

public class UnitOfWork:IUnitOfWork
{
    private readonly RedeemUzDbContext _context;

    public UnitOfWork(RedeemUzDbContext context)
    {
        _context = context;
        UserRepository = new Repository<User>(_context);
    }

    public IRepository<User> UserRepository { get; }

    public async ValueTask SaveAsync() => await _context.SaveChangesAsync();
    
    public void Dispose()
    {
        GC.SuppressFinalize(true);
    }
}