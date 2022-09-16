using FNS.Contexts.Infrastructure;
using FNS.ContextsInfrastructure.Repositories.Products;
using FNS.Domain.Models.Purchases;
using FNS.Domain.Repositories.Purchases;

namespace FNS.Infrastructure.Repositories.Purchases
{
    internal sealed class PurchaseInvoiceItemsRepository : RepositoryBase<PurchaseInvoiceItem>, IPurchaseInvoiceItemsRepository
    {
        public PurchaseInvoiceItemsRepository(AppDbContext db) : base(db)
        {
            // nothing
        }
    }
}
