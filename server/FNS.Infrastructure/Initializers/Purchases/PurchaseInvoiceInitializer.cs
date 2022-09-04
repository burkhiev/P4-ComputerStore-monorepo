using FNS.ContextsInfrastructure.Initializers;
using FNS.Domain.Models.Purchases;
using FNS.Infrastructure.Initializers.Identity;

namespace FNS.Infrastructure.Initializers.Purchases
{
    internal sealed class PurchaseInvoiceInitializer : IDataInitializer<PurchaseInvoice>
    {
        private readonly IEnumerable<PurchaseInvoice> _entities;

        public PurchaseInvoiceInitializer()
        {
            var users = new UsersInitializer().Entities.ToArray();

            string guidBasis1 = "00000000-0000-0000-0000-00000000000";

            var entities = new List<PurchaseInvoice>
            {
                new PurchaseInvoice
                {
                    Id = Guid.Parse(guidBasis1 + "1").ToString(),
                    UserId = users[2].Id,
                }
            };

            _entities = entities.AsReadOnly();
        }

        public IEnumerable<PurchaseInvoice> Entities => _entities;
    }
}
