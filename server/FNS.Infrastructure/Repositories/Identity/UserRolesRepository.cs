using System.Linq.Expressions;
using FNS.Contexts.Infrastructure;
using FNS.Domain.Repositories.Identity;
using Microsoft.AspNetCore.Identity;

namespace FNS.Infrastructure.Repositories.Identity
{
    internal sealed class UserRolesRepository : IUserRolesRepository
    {
        private readonly AppDbContext _db;

        public UserRolesRepository(AppDbContext db)
        {
            _db = db;
        }

        public AppDbContext Db => _db;

        public async Task<IdentityUserRole<string>> AddAsync(IdentityUserRole<string> value)
        {
            var entry = await Db.UserRoles.AddAsync(value);
            return entry.Entity;
        }

        public IQueryable<IdentityUserRole<string>> FindByCondition(Expression<Func<IdentityUserRole<string>, bool>> condition)
        {
            var entities = Db.UserRoles.Where(condition);
            return entities;
        }

        public async Task<IdentityUserRole<string>?> FindByIdAsync(string id)
        {
            var entity = await Db.UserRoles.FindAsync(id);
            return entity;
        }

        public IQueryable<IdentityUserRole<string>> GetAll()
        {
            var entities = Db.UserRoles.AsQueryable();
            return entities;
        }

        public Task LoadCollectionsAsync(IdentityUserRole<string> entity, params Expression<Func<IdentityUserRole<string>, IEnumerable<object>>>[] collectionPropExp)
        {
            return Task.CompletedTask;
        }

        public Task LoadReferencesAsync(IdentityUserRole<string> entity, params Expression<Func<IdentityUserRole<string>, object?>>[] collectionPropExp)
        {
            return Task.CompletedTask;
        }

        public IdentityUserRole<string> Remove(IdentityUserRole<string> value)
        {
            var entry = Db.UserRoles.Remove(value);
            return entry.Entity;
        }

        public void RemoveMany(IEnumerable<IdentityUserRole<string>> values)
        {
            Db.UserRoles.RemoveRange(values);
        }

        public IdentityUserRole<string> Update(IdentityUserRole<string> value)
        {
            var entry = Db.UserRoles.Update(value);
            return entry.Entity;
        }

        public void UpdateMany(IEnumerable<IdentityUserRole<string>> values)
        {
            Db.UserRoles.UpdateRange(values);
        }
    }
}
