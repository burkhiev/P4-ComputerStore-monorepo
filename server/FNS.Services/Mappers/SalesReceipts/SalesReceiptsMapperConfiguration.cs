using AutoMapper;
using FNS.Domain.Models.SalesReceipts;
using FNS.Services.Dtos.Products;
using FNS.Services.Dtos.SalesReceipts;
using FNS.Services.Mappers.Products;

namespace FNS.Services.Mappers.SalesReceipts
{
    internal sealed class SalesReceiptsMapperConfiguration : IBaseMapperConguration
    {
        private readonly MapperConfiguration _mapperConfiguration;

        public SalesReceiptsMapperConfiguration()
        {
            _mapperConfiguration = new MapperConfiguration(config => Configure(config));
        }

        public IMapper Mapper => _mapperConfiguration.CreateMapper();

        private void Configure(IMapperConfigurationExpression config)
        {
            config.CreateMap<SalesReceipt, SalesReceiptDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt));

            config.CreateMap<SalesReceipt, SalesReceiptWithAdditionalInfoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ConcurrencyToken, opt => opt.MapFrom(src => src.ConcurrencyToken))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.Details, opt => opt.MapFrom((src, dest) =>
                {
                    var productMapper = new ProductMapperConfiguration().Mapper;
                    var details = new List<SalesReceiptWithProductDto>(src.SalesReceiptsWithProducts.Count);

                    foreach(var item in src.SalesReceiptsWithProducts)
                    {
                        details.Add(new SalesReceiptWithProductDto
                        {
                            Id = item.Id,
                            Amount = item.Amount,
                            Product = productMapper.Map<ProductDto>(item.Product)
                        });
                    }

                    return details;
                }));
        }
    }
}
