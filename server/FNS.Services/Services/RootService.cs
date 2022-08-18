using FNS.Domain.Repositories;
using FNS.Services.Abstractions;
using FNS.Services.Abstractions.Products;
using FNS.Services.Services.Products;

namespace FNS.Services.Services
{
    public sealed class RootService : IRootService
    {
        private readonly IRootRepository _rootRepository;
        private readonly Lazy<IProductsService> _productsService;

        public RootService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;

            _productsService = new Lazy<IProductsService>(() => new ProductService(_rootRepository));
        }

        public IProductsService ProductsService => _productsService.Value;
    }
}
