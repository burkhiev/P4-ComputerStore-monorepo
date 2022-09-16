using FNS.ContextsInfrastructure.Initializers;
using FNS.ContextsInfrastructure.Initializers.Products;
using FNS.Domain.Models.SalesReceipts;

namespace FNS.Infrastructure.Initializers.SalesReceipts
{
    internal sealed class SalesReceiptWithProductInitializer : IDataInitializer<SalesReceiptWithProduct>
    {
        private readonly IEnumerable<SalesReceiptWithProduct> _entities;

        public SalesReceiptWithProductInitializer()
        {
            var products = new ProductsInitializer().Entities.ToArray();
            var salesReceipts = new SalesReceiptInitializer().Entities.ToArray();

            var guidBasis1 = "00000000-0000-0000-0000-00000000000";

            var entities = new List<SalesReceiptWithProduct>
            {
                new SalesReceiptWithProduct
                {
                    Id = Guid.Parse(guidBasis1 + "1").ToString(),
                    Amount = 1,
                    ProductId = products[3].Id,
                    SalesReceiptId = salesReceipts[0].Id,
                },
                new SalesReceiptWithProduct
                {
                    Id = Guid.Parse(guidBasis1 + "2").ToString(),
                    Amount = 1,
                    ProductId = products[1].Id,
                    SalesReceiptId = salesReceipts[0].Id,
                },
                new SalesReceiptWithProduct
                {
                    Id = Guid.Parse(guidBasis1 + "3").ToString(),
                    Amount = 1,
                    ProductId = products[0].Id,
                    SalesReceiptId = salesReceipts[2].Id,
                },
                new SalesReceiptWithProduct
                {
                    Id = Guid.Parse(guidBasis1 + "4").ToString(),
                    Amount = 1,
                    ProductId = products[3].Id,
                    SalesReceiptId = salesReceipts[1].Id,
                },
            };

            _entities = entities.AsReadOnly();
        }

        public IEnumerable<SalesReceiptWithProduct> Entities => _entities;
    }
}
