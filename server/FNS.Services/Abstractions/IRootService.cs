using FNS.Services.Abstractions.Indentity;
using FNS.Services.Abstractions.Products;
using FNS.Services.Abstractions.SalesReceipts;
using FNS.Services.Abstractions.ShoppingCarts;

namespace FNS.Services.Abstractions
{
    public interface IRootService
    {
        IProductsService ProductsService { get; }
        IShoppingCartService ShoppingCartService { get; }
        IUserService UserService { get; }
        ISalesReceiptService SalesReceiptService { get; }
    }
}
