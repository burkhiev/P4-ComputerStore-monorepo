using FNS.Domain.Models.Products;
using FNS.Infrastructure.Initializers.Products;
//using static FNS.Infrastructure.Initializers.Products.ProductAttributeInitializer;

namespace FNS.Infrastructure.Initializers
{
    internal class InitializedDataRepository
    {
        private readonly IEnumerable<Product> _products;
        private readonly IEnumerable<SubCategory> _subCategories;
        private readonly IEnumerable<ProductAttribute> _productAttributes;
        private readonly IEnumerable<ProductAttributeValue> _productAttributeValues;


        public InitializedDataRepository()
        {
            var productInit = new ProductInitializer();
            var subCategoryInit = new SubCategoryInitializer();
            var productAttributeInit = new ProductAttributeInitializer();
            var productAttributeValuesInit = new ProductAttributeValuesInitializer();

            _products = productInit.Entities;
            _subCategories = subCategoryInit.Entities;
            _productAttributes = productAttributeInit.Entities;
            _productAttributeValues = productAttributeValuesInit.Entities;

            InitializeTablesReferences();
        }

        public IEnumerable<Product> Products => _products;

        public IEnumerable<SubCategory> SubCategories => _subCategories;

        public IEnumerable<ProductAttribute> ProductAttributes => _productAttributes;

        public IEnumerable<ProductAttributeValue> ProductAttributeValues => _productAttributeValues;

        private void InitializeTablesReferences()
        {
            Initialize_Products_To_SubCategory_Reference();
        }

        private void Initialize_Products_To_SubCategory_Reference()
        {
            var subCategory = SubCategories.First(x => x.Name == "Процессоры");

            foreach(var product in _products)
            {
                product.SubCategoryId = subCategory.Id;
            }
        }

        private void Initialize_ProductAttributeValue_To_Product_And_ProductAttribute_Reference()
        {
            var model = ProductAttributes.First(x => x.Name == ProductAttributeInitializer.AttributeNames.Model);
            var socket = ProductAttributes.First(x => x.Name == ProductAttributeInitializer.AttributeNames.Socket);
            var manufacturerCode = ProductAttributes.First(x => x.Name == ProductAttributeInitializer.AttributeNames.ManufacturerCode);
            var releaseYear = ProductAttributes.First(x => x.Name == ProductAttributeInitializer.AttributeNames.ReleaseYear);
            var maxThreads = ProductAttributes.First(x => x.Name == ProductAttributeInitializer.AttributeNames.MaximumThreads);
            var numberOfPerformanceCores = ProductAttributes.First(x => x.Name == ProductAttributeInitializer.AttributeNames.NumberOfPerformanceCores);
            var numberOfEnergyEfficientCores = ProductAttributes.First(x => x.Name == ProductAttributeInitializer.AttributeNames.NumberOfEnergyEfficientCores);
            var l2CacheSize = ProductAttributes.First(x => x.Name == ProductAttributeInitializer.AttributeNames.L2CacheSize);
            var l3CacheSize = ProductAttributes.First(x => x.Name == ProductAttributeInitializer.AttributeNames.L3CacheSize);
            var processTechnology = ProductAttributes.First(x => x.Name == ProductAttributeInitializer.AttributeNames.ProcessTechnology);
            var core = ProductAttributes.First(x => x.Name == ProductAttributeInitializer.AttributeNames.Core);

            // TODO: ...
        }
    }
}
