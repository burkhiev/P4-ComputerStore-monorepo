using FNS.Contexts.Infrastructure;
using FNS.ContextsInfrastructure.Repositories.Products;
using FNS.Domain.Models.SalesReceipts;
using FNS.Domain.Repositories.SalesReceipts;
using Microsoft.EntityFrameworkCore;

namespace FNS.Infrastructure.Repositories.SalesReceipts
{
    internal sealed class SalesReceiptWithProductRepository : RepositoryBase<SalesReceiptWithProduct>, ISalesReceiptWithProductRepository
    {
        public SalesReceiptWithProductRepository(AppDbContext db) : base(db)
        {
            // do nothing
        }

        public async Task LoadAdditionalInfoBySalesReceiptId(string salesReceiptId, CancellationToken ct = default)
        {
            await Db.SalesReceiptsWithProducts
                .Where(e => e.SalesReceiptId == salesReceiptId)
                .Include(e => e.SalesReceipt)
                .Include(e => e.Product)
                .LoadAsync(ct);
        }
    }
}
