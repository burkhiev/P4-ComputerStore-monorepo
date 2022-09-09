using FNS.Domain.Models;
using System.Linq.Expressions;

namespace FNS.Domain.Repositories
{
    public interface IRepositoryBase<T> where T : class, new()
    {
        IQueryable<T> GetAll();
        Task<T?> FindByIdAsync(string id);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition);
        Task<T> AddAsync(T value);
        T Update(T value);
        void UpdateMany(IEnumerable<T> values);
        T Remove(T value);
        void RemoveMany(IEnumerable<T> values);
        Task LoadCollectionsAsync(T entity, params Expression<Func<T, IEnumerable<object>>>[] collectionPropExp);
        Task LoadReferencesAsync(T entity, params Expression<Func<T, object?>>[] collectionPropExp);
    }
}
