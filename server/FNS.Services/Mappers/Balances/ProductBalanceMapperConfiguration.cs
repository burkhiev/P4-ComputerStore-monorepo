using AutoMapper;
using FNS.Domain.Models.Balances;
using FNS.Services.Dtos.Balances;

namespace FNS.Services.Mappers.Balances
{
    internal sealed class ProductBalanceMapperConfiguration : IBaseMapperConguration
    {
        private readonly MapperConfiguration _mapperConfig;

        public ProductBalanceMapperConfiguration()
        {
            _mapperConfig = new MapperConfiguration(config => Configure(config));
        }

        public IMapper Mapper => _mapperConfig.CreateMapper();

        private void Configure(IMapperConfigurationExpression config)
        {
            config.CreateMap<ProductBalance, ProductBalanceDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount));
        }
    }
}
