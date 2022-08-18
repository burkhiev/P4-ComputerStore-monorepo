using FNS.Domain.Repositories;
using FNS.Domain.Repositories.Products;
using FNS.Infrastructure.Repositories.Products;

namespace FNS.Infrastructure.Repositories
{
    public class RootRepository : IRootRepository
    {
        private readonly IProductRepositoryManager _productRepositoryManager;
        private readonly AppDbContext _db;

        public RootRepository(AppDbContext db)
        {
            _db = db;
            _productRepositoryManager = new ProductRepositoryManager(_db);
        }

        public AppDbContext Db => _db;

        public IProductRepositoryManager ProductRepositoryManager => _productRepositoryManager;

        public Task<int> SaveChangesAsync(CancellationToken ct = default)
        {
            return Db.SaveChangesAsync(ct);
        }
    }
}
