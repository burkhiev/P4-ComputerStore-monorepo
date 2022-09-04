using FNS.Domain.Models;
using System.Linq.Expressions;

namespace FNS.Domain.Repositories
{
    public interface IRepositoryBase<T> where T : class, IEntityBase, new()
    {
        IQueryable<T> GetAll();
        Task<T?> FindByIdAsync(string id, CancellationToken ct = default);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition);
        Task<T> AddAsync(T value);
        T Update(T value);
        T Remove(T value);
        Task LoadCollectionsAsync(T entity, CancellationToken ct = default, params Expression<Func<T, IEnumerable<object>>>[] collectionPropExp);
        Task LoadReferencesAsync(T entity, CancellationToken ct = default, params Expression<Func<T, object?>>[] collectionPropExp);
    }
}
