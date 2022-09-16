using FNS.Contexts.Infrastructure;
using FNS.ContextsInfrastructure.Repositories.Products;
using FNS.Domain.Models.SalesReceipts;
using FNS.Domain.Repositories.SalesReceipts;

namespace FNS.Infrastructure.Repositories.SalesReceipts
{
    internal sealed class SalesReceiptRepository : RepositoryBase<SalesReceipt>, ISalesReceiptRepository
    {
        public SalesReceiptRepository(AppDbContext db) : base(db)
        {
            // do nothing
        }
    }
}
