using AutoMapper;
using FNS.Domain.Models.Products;
using FNS.Services.Dtos.Products;
using FNS.Services.Mappers.Consts;
using FNS.Services.Mappers.Products;

namespace FNS.Services.Mappers
{
    internal sealed class ProductMapperConfiguration : IMapperCongurationBase
    {
        private readonly MapperConfiguration _mapperConfig;

        public ProductMapperConfiguration()
        {
            _mapperConfig = new MapperConfiguration(config => Configure(config));
        }

        public IMapper Mapper => _mapperConfig.CreateMapper();

        private void Configure(IMapperConfigurationExpression config)
        {
            config.CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.GetType().Name));

            config.CreateMap<Product, ProductWithAdditionalInfoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.GetType().Name))
                .ForMember(dest => dest.ConcurrencyToken, opt => opt.MapFrom(src => src.ConcurrencyToken))
                .ForMember(dest => dest.AdditionalAttributes, opt => opt.MapFrom((src, dest) =>
                {
                    var attrs = new Dictionary<string, dynamic?>();
                    var attrValues = src.ProductAttributeValues;

                    attrs.Add(AppMappersConsts.ConcurrencyTokenAttributeName, src.ConcurrencyToken);

                    foreach(var attrValue in attrValues)
                    {
                        var attr = attrValue.ProductAttribute;
                        attrs[attr.Name] = attrValue.Value;

                        if(attrValue.Value is null)
                        {
                            attrs[attr.Name] = null;
                        }
                        else if(attr.ClrType.Equals(typeof(string).Name, StringComparison.OrdinalIgnoreCase))
                        {
                            attrs[attr.Name] = attrValue.Value;
                        }
                        else if(attr.ClrType.Equals(typeof(int).Name, StringComparison.OrdinalIgnoreCase))
                        {
                            attrs[attr.Name] = int.Parse(attrValue.Value);
                        }
                        else if(attr.ClrType.Equals(typeof(float).Name, StringComparison.OrdinalIgnoreCase))
                        {
                            attrs[attr.Name] = float.Parse(attrValue.Value);
                        }
                        else if(attr.ClrType.Equals(typeof(double).Name, StringComparison.OrdinalIgnoreCase))
                        {
                            attrs[attr.Name] = double.Parse(attrValue.Value);
                        }
                        else if(attr.ClrType.Equals(typeof(decimal).Name, StringComparison.OrdinalIgnoreCase))
                        {
                            attrs[attr.Name] = decimal.Parse(attrValue.Value);
                        }
                        else
                        {
                            throw new NotImplementedException();
                        }
                    }

                    return attrs;
                }));
        }
    }
}
