using FNS.Domain.Repositories.Products;

namespace FNS.Domain.Repositories
{
    public interface IRootRepository : IUnitOfWork
    {
        IProductRepositoryManager ProductRepositoryManager { get; }
    }
}
