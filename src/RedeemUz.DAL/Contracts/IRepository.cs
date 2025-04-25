using System.Linq.Expressions;
using Taxify.Domain.Commons;

namespace Taxify.DataAccess.Contracts;

public interface IRepository<TEntity> where TEntity : Auditable
{
    ValueTask CreateAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    void Destroy(TEntity entity);
    ValueTask<TEntity> SelectAsync(Expression<Func<TEntity, bool>> expression, string[] includes = null);
    IQueryable<TEntity> SelectAll(Expression<Func<TEntity, bool>> expression = null, string[] includes = null,
        bool isTracking = true);
}
