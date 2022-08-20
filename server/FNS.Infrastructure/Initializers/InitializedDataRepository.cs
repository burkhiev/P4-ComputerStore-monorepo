using FNS.Domain.Models.Products;
using FNS.Infrastructure.Initializers.Products;

namespace FNS.Infrastructure.Initializers
{
    [Obsolete]
    internal class InitializedDataRepository
    {
        private readonly IEnumerable<Product> _products;
        private readonly IEnumerable<SubCategory> _subCategories;
        private readonly IEnumerable<ProductAttribute> _productAttributes;
        private readonly IEnumerable<ProductAttributeValue> _productAttributeValues;


        public InitializedDataRepository()
        {
            var productInit = new ProductsInitializer();
            var subCategoryInit = new SubCategoriesInitializer();
            var productAttributeInit = new ProductAttributesInitializer();
            var productAttributeValuesInit = new ProductAttributeValuesInitializer();

            _products = productInit.Entities;
            _subCategories = subCategoryInit.Entities;
            _productAttributes = productAttributeInit.Entities;
            _productAttributeValues = productAttributeValuesInit.Entities;
        }

        public IEnumerable<Product> Products => _products;

        public IEnumerable<SubCategory> SubCategories => _subCategories;

        public IEnumerable<ProductAttribute> ProductAttributes => _productAttributes;

        public IEnumerable<ProductAttributeValue> ProductAttributeValues => _productAttributeValues;
    }
}
