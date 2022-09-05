using AutoMapper;
using FNS.Domain.Models.Products;
using FNS.Services.Dtos.Products;

namespace FNS.Services.Mappers.Products
{
    internal sealed class ProductAttributesMapperConfiguration : IBaseMapperConguration
    {
        private readonly MapperConfiguration _config;

        public ProductAttributesMapperConfiguration()
        {
            _config = new MapperConfiguration(cfg => Configure(cfg));
        }

        public IMapper Mapper => _config.CreateMapper();

        private void Configure(IMapperConfigurationExpression config)
        {
            config.CreateMap<ProductAttribute, ProductAttributeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ConcurrencyToken, opt => opt.MapFrom(src => src.xmin))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.ClrType))
                .ForMember(dest => dest.Measure, opt => opt.MapFrom(src => src.Measure))
                .ReverseMap();

            config.CreateMap<ProductAttributeForCreateDto, ProductAttribute>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ClrType, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Measure, opt => opt.MapFrom(src => src.Measure));
        }
    }
}
