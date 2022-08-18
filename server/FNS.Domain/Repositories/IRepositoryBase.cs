using FNS.Domain.Models;
using System.Linq.Expressions;

namespace FNS.Domain.Repositories
{
    public interface IRepositoryBase<T> where T : EntityBase, new()
    {
        IQueryable<T> GetAll();
        Task<T?> FindAsync(Guid id, CancellationToken ct = default);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition);
        Task<T> AddAsync(T entity);
        T Update(T entity);
        T Remove(T entity);
    }
}
