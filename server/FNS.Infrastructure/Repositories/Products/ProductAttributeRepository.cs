using FNS.Domain.Models.Products;
using FNS.Domain.Repositories.Products;
using System.Linq.Expressions;

namespace FNS.Infrastructure.Repositories.Products
{
    public class ProductAttributeRepository : IProductAttributeRepository
    {
        private readonly AppDbContext _db;

        public ProductAttributeRepository(AppDbContext db)
        {
            _db = db;
        }

        public AppDbContext Db => _db;

        public async Task<ProductAttribute> AddAsync(ProductAttribute entity)
        {
            var result = await Db.ProductAttributes.AddAsync(entity);
            return result.Entity;
        }

        public async Task<ProductAttribute?> FindAsync(Guid id, CancellationToken ct = default)
        {
            var result = await Db.ProductAttributes.FindAsync(id, ct);
            return result;
        }

        public IQueryable<ProductAttribute> FindByCondition(Expression<Func<ProductAttribute, bool>> condition)
        {
            var result = Db.ProductAttributes.Where(condition);
            return result;
        }

        public IQueryable<ProductAttribute> GetAll()
        {
            var result = Db.ProductAttributes.AsQueryable();
            return result;
        }

        public ProductAttribute Remove(ProductAttribute entity)
        {
            var result = Db.ProductAttributes.Remove(entity);
            return result.Entity;
        }

        public ProductAttribute Update(ProductAttribute entity)
        {
            var result = Db.ProductAttributes.Update(entity);
            return result.Entity;
        }
    }
}
