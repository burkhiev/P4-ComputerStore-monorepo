using FNS.Domain.Models;
using FNS.Domain.Repositories;
using System.Linq.Expressions;

namespace FNS.Infrastructure.Repositories.Products
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase, new()
    {
        private readonly AppDbContext _db;

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

        public async Task<T?> FindByIdAsync(Guid id, CancellationToken ct = default)
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

        public T Remove(T value)
        {
            var entity = Db.Set<T>().Find(value.Id);

            if(entity is null)
            {
                return value;
            }

            entity.Tumbstone = true;
            return entity;
        }

        public T RemovePermanently(T value)
        {
            var result = Db.Set<T>().Remove(value);
            return result.Entity;
        }
    }
}
