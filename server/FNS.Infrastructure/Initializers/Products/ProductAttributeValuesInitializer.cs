using FNS.Domain.Models.Products;

namespace FNS.Infrastructure.Initializers.Products
{
    internal class ProductAttributeValuesInitializer : IDataInitializer<ProductAttributeValue>
    {
        private readonly object _locker = new object();
        private readonly IEnumerable<ProductAttributeValue> _entities;

        public ProductAttributeValuesInitializer()
        {
            lock (_locker)
            {
                var guidBasis = "00000000-0000-0000-0000-00000000000";

                var entities = new List<ProductAttributeValue>
                {
                    //new ProductAttributeValue { Id = Guid.Parse(guidBasis + 1), ProductId =  }
                };

                _entities = entities.AsReadOnly();
            }
        }

        public IEnumerable<ProductAttributeValue> Entities => _entities;
    }
}
