using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos;
using FNS.Services.Dtos.ShoppingCarts;

namespace FNS.Services.Abstractions.ShoppingCarts
{
    public interface IShoppingCartsService
    {
        public AppOpResult<IEnumerable<ShoppingCartDto>> GetAll();
        public Task<AppOpResult<ShoppingCartWithAdditionalInfoDto>> GetByUserIdWithAdditionalInfoAsync(string userId, CancellationToken ct = default);
        public Task<AppOpResult<EmptyDto>> AddProductAsync(string userId, string productId);
        public Task<AppOpResult<ShoppingCartForChangeItemAmountDto>> UpdateItemAmountAsync(string userId, string cartItemId, int newAmount);
        public Task<AppOpResult<EmptyDto>> DeleteItemAsync(string userId, string cartItemId);
    }
}
