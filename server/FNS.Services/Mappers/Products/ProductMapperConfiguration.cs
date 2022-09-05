using AutoMapper;
using FNS.Domain.Models.Products;
using FNS.Services.Dtos.Products;

namespace FNS.Services.Mappers.Products
{
    internal sealed class ProductMapperConfiguration : IBaseMapperConguration
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
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ProductCode, opt => opt.MapFrom(src => src.ProductCode))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.SubCategoryId, opt => opt.MapFrom(src => src.SubCategoryId));

            config.CreateMap<Product, ProductWithAdditionalInfoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ConcurrencyToken, opt => opt.MapFrom(src => src.xmin))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ProductCode, opt => opt.MapFrom(src => src.ProductCode))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.SubCategoryId, opt => opt.MapFrom(src => src.SubCategoryId))
                .ForMember(dest => dest.AdditionalAttributes, opt => opt.MapFrom((src, dest) =>
                {
                    var attrs = new Dictionary<string, dynamic?>();
                    var attrValues = src.ProductAttributeValues;

                    if(attrValues is null)
                    {
                        return attrs;
                    }

                    foreach(var attrValue in attrValues)
                    {
                        var attr = attrValue.ProductAttribute;

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
                            throw new NotImplementedException("Not implemented CLR type converting.");
                        }
                    }

                    return attrs;
                }));

            config.CreateMap<ProductWithAdditionalInfoDto, Product>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.xmin, opt => opt.MapFrom(src => src.ConcurrencyToken))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ProductCode, opt => opt.MapFrom(src => src.ProductCode))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.SubCategoryId, opt => opt.MapFrom(src => src.SubCategoryId))
                .ForMember(dest => dest.ProductAttributeValues, opt => opt.Ignore());

            config.CreateMap<ProductForCreateDto, Product>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.ProductCode, opt => opt.MapFrom(src => src.ProductCode))
                .ForMember(dest => dest.SubCategoryId, opt => opt.MapFrom(src => src.SubCategoryId));
        }
    }
}
