using FNS.Domain.Models.Products;
using FNS.Domain.Repositories.Products;
using System.Linq.Expressions;

namespace FNS.Infrastructure.Repositories.Products
{
    internal class PriceRepository : IPriceRepository
    {
        private readonly AppDbContext _db;

        public PriceRepository(AppDbContext db)
        {
            _db = db;
        }

        private AppDbContext Db => _db;

        public Task<Price> AddAsync(Price entity)
        {
            throw new NotImplementedException();
        }

        public Task<Price?> FindAsync(Guid id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Price> FindByCondition(Expression<Func<Price, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Price> GetAll()
        {
            throw new NotImplementedException();
        }

        public Price Remove(Price entity)
        {
            throw new NotImplementedException();
        }

        public Price Update(Price entity)
        {
            throw new NotImplementedException();
        }
    }
}