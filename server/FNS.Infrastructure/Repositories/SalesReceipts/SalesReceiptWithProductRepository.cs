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

        public async Task LoadAdditionalInfoBySalesReceiptId(string salesReceiptId)
        {
            await Db.SalesReceiptsWithProducts
                .Include(e => e.SalesReceipt)
                .Include(e => e.Product)
                .Where(e => e.SalesReceiptId == salesReceiptId)
                .LoadAsync();
        }

        public async Task LoadAdditionalInfoByUserId(string userId)
        {
            await Db.SalesReceiptsWithProducts
                .Include(e => e.SalesReceipt)
                .Include(e => e.Product)
                .Where(e => e.SalesReceipt.UserId == userId)
                .LoadAsync();
        }
    }
}
