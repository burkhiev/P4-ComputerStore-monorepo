using FNS.Contexts.Infrastructure;
using FNS.ContextsInfrastructure.Repositories.Products;
using FNS.Domain.Models.Balances;
using FNS.Domain.Repositories.Balances;

namespace FNS.Infrastructure.Repositories.Balances
{
    internal sealed class ProductBalancesRepository : RepositoryBase<ProductBalance>, IProductBalanceRepository
    {
        public ProductBalancesRepository(AppDbContext db) : base(db)
        {
            // do nothing
        }
    }
}
