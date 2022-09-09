using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos;
using FNS.Services.Dtos.ShoppingCarts;

namespace FNS.Services.Abstractions.ShoppingCarts
{
    public interface IShoppingCartsService
    {
        public OpResult<IEnumerable<ShoppingCartDto>> GetAll();
        public Task<OpResult<ShoppingCartWithAdditionalInfoDto>> GetByUserIdWithAdditionalInfoAsync(string userId);
        public Task<OpResult<ShoppingCartItemDto>> AddProductAsync(string userId, string productId);
        public Task<OpResult<ShoppingCartForChangeItemAmountDto>> UpdateItemAmountAsync(ShoppingCartForChangeItemAmountDto dto);
        public Task<OpResult<EmptyDto>> DeleteItemAsync(string userId, string cartItemId);
    }
}
