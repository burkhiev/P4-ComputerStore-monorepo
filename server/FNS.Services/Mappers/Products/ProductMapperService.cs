using AutoMapper;
using FNS.Domain.Models.Products;
using FNS.Services.Dtos.Products;

namespace FNS.Services.Mappers.Products
{
    internal static class ProductMapperService
    {
        private static readonly object _locker = new object();
        private static readonly MapperConfiguration _mapperConfig;

        static ProductMapperService()
        {
            lock(_locker)
            {
                if(_mapperConfig is not null)
                {
                    return;
                }

                _mapperConfig = new MapperConfiguration(config =>
                {
                    CreateProductMaps(config);
                });
            }
        }

        public static IMapper Mapper => _mapperConfig.CreateMapper();

        public static MapperConfiguration MapperConfiguration => _mapperConfig;

        private static void CreateProductMaps(IMapperConfigurationExpression config)
        {
            config.CreateMap<Product, ProductDto>();

            config.CreateProjection<Product, ProductDto>();

            config.CreateMap<Product, ProductAdditionalInfoDto>()
                .ForMember(dest => dest.Attributes, opt => opt.Ignore());

            //config.CreateMap<ProductAttributeValue, ProductAttributeValueDto>()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ProductAttribute.Name))
            //    .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
            //    .ForMember(dest => dest.Measure, opt => opt.MapFrom(src => src.ProductAttribute.Measure))
            //    .ForMember(dest => dest.TSType, opt => opt.MapFrom((src, dest) =>
            //     {
            //         string clrType = src.ProductAttribute.ClrType;

            //         if(IsNumberTypeName(clrType))
            //         {
            //             return TypescriptTypeNames.Number;
            //         }
            //         else if(clrType.Equals(typeof(string).Name, StringComparison.OrdinalIgnoreCase))
            //         {
            //             return TypescriptTypeNames.String;
            //         }

            //         throw new NotImplementedException();
            //     }));
        }
    }
}
