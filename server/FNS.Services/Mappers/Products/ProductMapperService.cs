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
            _mapperConfig = new MapperConfiguration(config =>
            {
                CreateProductMaps(config);
            });
        }

        public static IMapper Mapper
        {
            get
            {
                IMapper mapper;

                lock(_locker)
                {
                    mapper = _mapperConfig.CreateMapper();
                }

                return mapper;
            }
        }

        public static MapperConfiguration MapperConfiguration => _mapperConfig;

        private static void CreateProductMaps(IMapperConfigurationExpression config)
        {
            config.CreateProjection<Product, ProductDto>();

            config.CreateMap<Product, ProductAdditionalInfoDto>()
                .ForMember(dest => dest.SpecificAttributes, opt => opt.MapFrom((src, dest) =>
                {
                    var result = new Dictionary<string, object?>(src.ProductWithAttributeValues.Count);

                    foreach(var attr in src.ProductWithAttributeValues)
                    {
                        string key = attr.ProductAttribute.Name;
                        object? value = null;

                        if(attr.ProductAttribute.Type == typeof(string).Name)
                        {
                            value = attr.Value;
                        }
                        else if(attr.ProductAttribute.Type == typeof(decimal).Name)
                        {
                            if(decimal.TryParse(attr.Value, out decimal digit))
                            {
                                value = digit;
                            }
                        }

                        if(!result.TryAdd(key, value))
                        {
                            throw new InvalidOperationException("There is collision of the attribute names in the dictionary.");
                        }
                    }

                    return result;
                }));
        }
    }
}
