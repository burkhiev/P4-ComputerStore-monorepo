using FNS.Services.Abstractions.Products;

namespace FNS.Services.Abstractions
{
    public interface IRootService
    {
        IProductsService ProductsService { get; }
    }
}
