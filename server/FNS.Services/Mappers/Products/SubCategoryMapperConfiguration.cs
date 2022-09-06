using AutoMapper;
using FNS.Domain.Models.Products;
using FNS.Services.Dtos.Products;

namespace FNS.Services.Mappers.Products
{
    internal sealed class SubCategoryMapperConfiguration : IBaseMapperConguration
    {
        private readonly MapperConfiguration _mapperConfig;

        public SubCategoryMapperConfiguration()
        {
            _mapperConfig = new MapperConfiguration(config => Configure(config));
        }

        public IMapper Mapper => _mapperConfig.CreateMapper();

        private void Configure(IMapperConfigurationExpression config)
        {
            config.CreateMap<SubCategory, SubCategoryDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ConcurrencyToken, opt => opt.MapFrom(src => src.xmin))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ReverseMap();
        }
    }
}
