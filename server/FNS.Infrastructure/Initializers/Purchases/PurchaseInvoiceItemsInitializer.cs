using FNS.ContextsInfrastructure.Initializers;
using FNS.ContextsInfrastructure.Initializers.Products;
using FNS.Domain.Models.Purchases;

namespace FNS.Infrastructure.Initializers.Purchases
{
    internal sealed class PurchaseInvoiceItemsInitializer : IDataInitializer<PurchaseInvoiceItem>
    {
        private readonly IEnumerable<PurchaseInvoiceItem> _entities;

        public PurchaseInvoiceItemsInitializer()
        {
            var invoices = new PurchaseInvoiceInitializer().Entities.ToArray();
            var products = new ProductsInitializer().Entities.ToArray();

            string guidBasis1 = "00000000-0000-0000-0000-00000000000";

            var entities = new List<PurchaseInvoiceItem>
            {
                new PurchaseInvoiceItem
                {
                    Id = Guid.Parse(guidBasis1 + "1").ToString(),
                    ProductId = products[0].Id,
                    PurchaseInvoiceId = invoices[0].Id,
                    Amount = 2,
                },
                new PurchaseInvoiceItem
                {
                    Id = Guid.Parse(guidBasis1 + "2").ToString(),
                    ProductId = products[1].Id,
                    PurchaseInvoiceId = invoices[0].Id,
                    Amount = 3,
                },
                new PurchaseInvoiceItem
                {
                    Id = Guid.Parse(guidBasis1 + "3").ToString(),
                    ProductId = products[2].Id,
                    PurchaseInvoiceId = invoices[0].Id,
                    Amount = 7,
                },
                new PurchaseInvoiceItem
                {
                    Id = Guid.Parse(guidBasis1 + "4").ToString(),
                    ProductId = products[3].Id,
                    PurchaseInvoiceId = invoices[0].Id,
                    Amount = 5,
                },
            };

            _entities = entities.AsReadOnly();
        }

        public IEnumerable<PurchaseInvoiceItem> Entities => _entities;
    }
}
