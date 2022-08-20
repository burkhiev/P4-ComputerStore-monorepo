using FNS.Domain.Repositories.Products;

namespace FNS.Infrastructure.Repositories.Products
{
    internal sealed class ProductRepositoryManager : IProductRepositoryManager
    {
        private readonly IProductRepository _productRepository;
        private readonly ISubCategoryRepository _subCategoryRepository;
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly IProductAttributeValueRepository _productAttributeValueRepository;

        public ProductRepositoryManager(AppDbContext _db)
        {
            _productRepository = new ProductRepository(_db);
            _subCategoryRepository = new SubCategoryRepository(_db);
            _productAttributeRepository = new ProductAttributeRepository(_db);
            _productAttributeValueRepository = new ProductAttributeValueRepository(_db);
        }

        public IPriceRepository PriceRepository => throw new NotImplementedException();

        public IProductAttributeRepository ProductAttributeRepository => _productAttributeRepository;

        public IProductRepository ProductRepository => _productRepository;

        public IProductAttributeValueRepository ProductWithAttributeValuesRepository => _productAttributeValueRepository;

        public ISubCategoryRepository SubCategoryRepository => _subCategoryRepository;
    }
}
