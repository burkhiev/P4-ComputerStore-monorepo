using FNS.Contexts.Infrastructure;
using FNS.Domain.Models;
using FNS.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FNS.ContextsInfrastructure.Repositories.Products
{
    internal abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntityBase, new()
    {
        protected const int MaxRecordsCount = 2000;
        protected const int ForDeletingEntitiesCount = 500;
        protected readonly AppDbContext _db;

        public RepositoryBase(AppDbContext db)
        {
            _db = db;
        }

        public AppDbContext Db => _db;

        public async Task<T> AddAsync(T entity)
        {
            // удаление старых записей
            var entities = Db.Set<T>().AsQueryable();

            if(entities.Count() > MaxRecordsCount)
            {
                var forDeletingEntities = await entities
                    .OrderBy(x => x.CreatedAt)
                    .Take(ForDeletingEntitiesCount)
                    .ToListAsync();

                Db.Set<T>().RemoveRange(forDeletingEntities);
                await Db.SaveChangesAsync();
            }

            var result = await Db.Set<T>().AddAsync(entity);
            return result.Entity;
        }

        public async Task<T?> FindByIdAsync(string id)
        {
            var result = await Db.Set<T>().FindAsync(id);
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

        public void UpdateMany(IEnumerable<T> values)
        {
            Db.Set<T>().UpdateRange(values);
        }

        public T Remove(T value)
        {
            var result = Db.Set<T>().Remove(value);
            return result.Entity;
        }

        public void RemoveMany(IEnumerable<T> values)
        {
            Db.Set<T>().RemoveRange(values);
        }

        public async Task LoadCollectionsAsync(T entity, params Expression<Func<T, IEnumerable<object>>>[] expressions)
        {
            var entry = Db.Entry(entity);

            for(int i = 0; i < expressions.Length; i++)
            {
                var exp = expressions[i];
                await entry.Collection(exp).LoadAsync();
            }
        }

        public async Task LoadReferencesAsync(T entity, params Expression<Func<T, object?>>[] expressions)
        {
            foreach(var exp in expressions)
            {
                await Db.Entry(entity).Reference(exp).LoadAsync();
            }
        }
    }
}
