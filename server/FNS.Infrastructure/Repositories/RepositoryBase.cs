using FNS.Contexts.Infrastructure;
using FNS.Domain.Models;
using FNS.Domain.Repositories;
using System.Linq.Expressions;

namespace FNS.ContextsInfrastructure.Repositories.Products
{
    internal abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntityBase, new()
    {
        protected readonly AppDbContext _db;

        public RepositoryBase(AppDbContext db)
        {
            _db = db;
        }

        public AppDbContext Db => _db;

        public async Task<T> AddAsync(T entity)
        {
            var result = await Db.Set<T>().AddAsync(entity);
            return result.Entity;
        }

        public async Task<T?> FindByIdAsync(string id, CancellationToken ct = default)
        {
            var result = await Db.Set<T>().FindAsync(new object[] { id }, ct);
            return result;
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition)
        {
            var result = Db.Set<T>().Where(condition);
            return result;
        }

        public IQueryable<T> GetAll()
        {
            var result = Db.Set<T>().AsQueryable();
            return result;
        }

        public T Update(T value)
        {
            var result = Db.Set<T>().Update(value);
            return result.Entity;
        }

        public IEnumerable<T> UpdateMany(IEnumerable<T> values)
        {
            Db.Set<T>().UpdateRange(values);
            return values;
        }

        public T Remove(T value)
        {
            var result = Db.Set<T>().Remove(value);
            return result.Entity;
        }

        public async Task LoadCollectionsAsync(T entity, CancellationToken ct = default, params Expression<Func<T, IEnumerable<object>>>[] expressions)
        {
            foreach(var exp in expressions)
            {
                await Db.Entry(entity).Collection(exp).LoadAsync(ct);
            }
        }

        public async Task LoadReferencesAsync(T entity, CancellationToken ct = default, params Expression<Func<T, object?>>[] expressions)
        {
            foreach(var exp in expressions)
            {
                await Db.Entry(entity).Reference(exp).LoadAsync(ct);
            }
        }
    }
}
