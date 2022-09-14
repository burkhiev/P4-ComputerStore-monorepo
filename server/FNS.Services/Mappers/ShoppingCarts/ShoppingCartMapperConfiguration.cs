using AutoMapper;
using FNS.Domain.Models.ShoppingCarts;
using FNS.Services.Dtos.Products;
using FNS.Services.Dtos.ShoppingCarts;
using FNS.Services.Mappers.Products;

namespace FNS.Services.Mappers.ShoppingCarts
{
    internal sealed class ShoppingCartMapperConfiguration : IBaseMapperConguration
    {

        private readonly MapperConfiguration _mapperConfig;
        public ShoppingCartMapperConfiguration()
        {
            _mapperConfig = new MapperConfiguration(config => Configure(config));
        }

        public IMapper Mapper => _mapperConfig.CreateMapper();

        private void Configure(IMapperConfigurationExpression config)
        {
            config.CreateMap<ShoppingCart, ShoppingCart>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.xmin, opt => opt.MapFrom(src => src.xmin));

            config.CreateMap<ShoppingCart, ShoppingCartDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId));

            config.CreateMap<ShoppingCart, ShoppingCartWithAdditionalInfoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.ShoppingCartItems, opt => opt.MapFrom((src, dest) =>
                {
                    var productMapper = new ProductMapperConfiguration().Mapper;
                    var shoppingCartItemDtos = new List<ShoppingCartItemWithProductDto>(src.ShoppingCartItems?.Count ?? 0);

                    if(src.ShoppingCartItems is null)
                    {
                        return shoppingCartItemDtos;
                    }

                    foreach(var item in src.ShoppingCartItems)
                    {
                        var productDto = productMapper.Map<ProductDto>(item.Product);

                        var shoppingCartItemDto = new ShoppingCartItemWithProductDto
                        {
                            Id = item.Id,
                            ShoppingCartId = src.Id,
                            Amount = item.Amount,
                            Product = productDto,
                        };

                        shoppingCartItemDtos.Add(shoppingCartItemDto);
                    }

                    return shoppingCartItemDtos;
                }));

            config.CreateMap<ShoppingCartItem, ShoppingCartItemDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount));
        }
    }
}
