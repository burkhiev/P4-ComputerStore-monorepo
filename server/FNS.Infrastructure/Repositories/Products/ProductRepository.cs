using FNS.Domain.Models.Products;
using FNS.Domain.Repositories.Products;
using System.Linq.Expressions;

namespace FNS.Infrastructure.Repositories.Products
{
    internal class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _db;

        public ProductRepository(AppDbContext db)
        {
            _db = db;
        }

        private AppDbContext Db => _db;

        public async Task<Product> AddAsync(Product entity)
        {
            var result = await Db.Products.AddAsync(entity);
            return result.Entity;
        }

        public async Task<Product?> FindAsync(Guid id, CancellationToken ct = default)
        {
            var result = await Db.Products.FindAsync(id, ct);
            return result;
        }

        public IQueryable<Product> FindByCondition(Expression<Func<Product, bool>> condition)
        {
            var result = Db.Products.Where(condition);
            return result;
        }

        public IQueryable<Product> GetAll()
        {
            var result = Db.Products.AsQueryable();
            return result;
        }

        public Product Remove(Product entity)
        {
            var result = Db.Products.Remove(entity);
            return result.Entity;
        }

        public Product Update(Product entity)
        {
            var result = Db.Products.Update(entity);
            return result.Entity;
        }
    }
}
