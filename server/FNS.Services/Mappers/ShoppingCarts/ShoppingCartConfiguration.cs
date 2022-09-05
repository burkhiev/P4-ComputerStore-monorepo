using AutoMapper;
using FNS.Domain.Models.ShoppingCarts;
using FNS.Services.Dtos.Products;
using FNS.Services.Dtos.ShoppingCarts;
using FNS.Services.Mappers.Products;

namespace FNS.Services.Mappers.ShoppingCarts
{
    internal sealed class ShoppingCartConfiguration : IBaseMapperConguration
    {

        private readonly MapperConfiguration _mapperConfig;
        public ShoppingCartConfiguration()
        {
            _mapperConfig = new MapperConfiguration(config => Configure(config));
        }

        public IMapper Mapper => _mapperConfig.CreateMapper();

        private void Configure(IMapperConfigurationExpression config)
        {
            config.CreateMap<ShoppingCart, ShoppingCartDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            config.CreateMap<ShoppingCart, ShoppingCartWithAdditionalInfoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ConcurrencyToken, opt => opt.MapFrom(src => src.xmin))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.ShoppingCartItems, opt => opt.MapFrom((src, dest) =>
                {
                    var productMapper = new ProductMapperConfiguration().Mapper;
                    var shoppingCartItemDtos = new List<ShoppingCartItemDto>(src.ShoppingCartItems.Count);

                    foreach(var item in src.ShoppingCartItems)
                    {
                        var productDto = productMapper.Map<ProductDto>(item.Product);

                        var shoppingCartItemDto = new ShoppingCartItemDto
                        {
                            Id = item.Id,
                            ShoppingCartId = src.Id,
                            Amount = item.Amount,
                            Product = productDto
                        };

                        shoppingCartItemDtos.Add(shoppingCartItemDto);
                    }

                    return shoppingCartItemDtos;
                }));
        }
    }
}
