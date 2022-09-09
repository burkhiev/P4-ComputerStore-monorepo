using FNS.Contexts.Infrastructure;
using FNS.ContextsInfrastructure.Repositories.Products;
using FNS.Domain.Models.Purchases;
using FNS.Domain.Repositories.Purchases;
using Microsoft.EntityFrameworkCore;

namespace FNS.Infrastructure.Repositories.Purchases
{
    internal sealed class PurchaseInvoicesRepository : RepositoryBase<PurchaseInvoice>, IPurchaseInvoicesRepository
    {
        public PurchaseInvoicesRepository(AppDbContext db) : base(db)
        {
            // nothing
        }

        public async Task LoadItemsWithProductsAsync(string invoiceId)
        {
            await Db.PurchaseInvoiceItems
                .Where(x => x.PurchaseInvoiceId == invoiceId)
                .Include(x => x.Product)
                .LoadAsync();
        }
    }
}
