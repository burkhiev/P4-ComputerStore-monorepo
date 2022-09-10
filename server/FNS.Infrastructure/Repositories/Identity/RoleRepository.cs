using System.Linq.Expressions;
using FNS.Contexts.Infrastructure;
using FNS.Domain.Models.Identity;
using FNS.Domain.Repositories.Identity;

namespace FNS.Infrastructure.Repositories.Identity
{
    internal sealed class RoleRepository : IRolesRepository
    {
        private readonly AppDbContext _db;

        public RoleRepository(AppDbContext db)
        {
            _db = db;
        }

        private AppDbContext Db => _db;

        public IQueryable<Role> GetAll()
        {
            var result = Db.Roles.AsQueryable();
            return result;
        }

        public async Task<Role?> FindByIdAsync(string id)
        {
            var entity = await Db.Roles.FindAsync(id);
            return entity;
        }

        public IQueryable<Role> FindByCondition(Expression<Func<Role, bool>> condition)
        {
            var result = Db.Roles.Where(condition);
            return result;
        }

        public async Task LoadCollectionsAsync(Role entity, params Expression<Func<Role, IEnumerable<object>>>[] collectionPropExp)
        {
            var entry = Db.Entry(entity);

            for(int i = 0; i < collectionPropExp.Length; i++)
            {
                var exp = collectionPropExp[i];
                await entry.Collection(exp).LoadAsync();
            }
        }

        public async Task LoadReferencesAsync(Role entity, params Expression<Func<Role, object?>>[] collectionPropExp)
        {
            var entry = Db.Entry(entity);

            for(int i = 0; i < collectionPropExp.Length; i++)
            {
                var exp = collectionPropExp[i];
                await entry.Reference(exp).LoadAsync();
            }
        }

        public async Task<Role> AddAsync(Role value)
        {
            var entry = await Db.Roles.AddAsync(value);
            return entry.Entity;
        }

        public Role Update(Role value)
        {
            var entry = Db.Roles.Update(value);
            return entry.Entity;
        }

        public void UpdateMany(IEnumerable<Role> values)
{
            Db.Roles.UpdateRange(values);
        }

        public Role Remove(Role value)
        {
            var entry = Db.Roles.Remove(value);
            return entry.Entity;
        }

        public void RemoveMany(IEnumerable<Role> values)
        {
            Db.Roles.RemoveRange(values);
        }
    }
}
