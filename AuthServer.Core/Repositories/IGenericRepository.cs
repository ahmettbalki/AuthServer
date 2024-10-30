using System.Linq.Expressions;
namespace AuthServer.Core.Repositories;
public interface IGenericRepository<TEntity, TId> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(TId id);
    IQueryable<TEntity> Where(Expression<Func<TEntity,bool>> predicate);
    Task AddAsync(TEntity entity);
    TEntity Update(TEntity entity);
    void Remove(TEntity entity);
}
