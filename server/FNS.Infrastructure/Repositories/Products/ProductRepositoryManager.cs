using FNS.Domain.Repositories.Products;

namespace FNS.Infrastructure.Repositories.Products
{
    internal class ProductRepositoryManager : IProductRepositoryManager
    {
        private readonly IProductRepository _productRepository;
        private readonly IPriceRepository _priceRepository;

        public ProductRepositoryManager(AppDbContext _db)
        {
            _productRepository = new ProductRepository(_db);
            _priceRepository = new PriceRepository(_db);
        }

        public IPriceRepository PriceRepository => throw new NotImplementedException();

        public IProductAttributeRepository ProductAttributeRepository => throw new NotImplementedException();

        public IProductRepository ProductRepository => _productRepository;

        public IProductWithAttributeValuesRepository ProductWithAttributeValuesRepository => throw new NotImplementedException();
    }
}
