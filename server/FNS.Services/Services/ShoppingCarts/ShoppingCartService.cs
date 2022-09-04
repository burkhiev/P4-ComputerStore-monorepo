using AutoMapper;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.ShoppingCarts;
using FNS.Services.Dtos.ShoppingCarts;
using FNS.Services.Mappers.ShoppingCarts;
using Microsoft.AspNetCore.Http;

namespace FNS.Services.Services.ShoppingCarts
{
    internal sealed class ShoppingCartService : IShoppingCartService
    {
        private readonly IRootRepository _rootRepository;
        private readonly ShoppingCartConfiguration _mapperConfig;

        public ShoppingCartService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _mapperConfig = new ShoppingCartConfiguration();
        }

        private IRootRepository RootRepository => _rootRepository;

        private IMapper Mapper => _mapperConfig.Mapper;

        [Obsolete("For debugging")]
        public AppOpResult<IEnumerable<ShoppingCartDto>> GetAll()
        {
            var shoppingCarts = RootRepository.ShoppingCartRepository.GetAll().ToArray();
            var dtos = Mapper.Map<IEnumerable<ShoppingCartDto>>(shoppingCarts);

            var result = new AppOpResult<IEnumerable<ShoppingCartDto>>(dtos);
            return result;
        }

        public async Task<AppOpResult<ShoppingCartWithAdditionalInfoDto>> GetByIdWithAdditionalInfoAsync(string id, CancellationToken ct = default)
        {
            var cart = await RootRepository.ShoppingCartRepository.FindByIdAsync(id , ct);

            if(cart is null)
            {
                var errResult = new ShoppingCartNotFoundResult();
                return errResult;
            }

            await RootRepository.ShoppingCartRepository.LoadShoppingCartsWithItemsAndProducts(cart, ct);

            var dto = Mapper.Map<ShoppingCartWithAdditionalInfoDto>(cart);
            var result = new AppOpResult<ShoppingCartWithAdditionalInfoDto>(dto);

            return result;
        }

        public async Task<AppOpResult<ShoppingCartWithAdditionalInfoDto?>> GetByUserIdAsync(string userId, CancellationToken ct = default)
        {
            var user = await RootRepository.UsersRepository.FindByIdAsync(userId, ct);

            if(user is null)
            {
                var errResult = new ShoppingCartNotFoundByUserIdResult();
                return errResult;
            }

            await RootRepository.UsersRepository.LoadReferencesAsync(user, ct, u => u.ShoppingCart);

            if(user.ShoppingCart is null)
            {
                var errResult = new ShoppingCartNotFoundByUserIdResult();
                return errResult;
            }

            await RootRepository.ShoppingCartRepository.LoadShoppingCartsWithItemsAndProducts(user.ShoppingCart, ct);

            var dto = Mapper.Map<ShoppingCartWithAdditionalInfoDto>(user.ShoppingCart);
            var result = new AppOpResult<ShoppingCartWithAdditionalInfoDto?>(dto);

            return result;
        }

        private sealed class ShoppingCartNotFoundByUserIdResult : AppOpResult<ShoppingCartWithAdditionalInfoDto?>
        {
            public ShoppingCartNotFoundByUserIdResult()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = "ShoppingCart not found",
                    Detail = $"ShoppingCart with specified userId is not found.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }

        private sealed class ShoppingCartNotFoundResult : AppOpResult<ShoppingCartWithAdditionalInfoDto>
        {
            public ShoppingCartNotFoundResult()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = "ShoppingCart not found",
                    Detail = $"ShoppingCart with specified Id is not found.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }
    }
}
