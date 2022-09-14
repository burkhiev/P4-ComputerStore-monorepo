using AutoMapper;
using FNS.Domain.Models.Products;
using FNS.Services.Dtos.Products;
using FNS.Services.Utils;

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
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ProductCode, opt => opt.MapFrom(src => src.ProductCode))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.SubCategoryId, opt => opt.MapFrom(src => src.SubCategoryId))
                .ForMember(dest => dest.AdditionalAttributes, opt => opt.MapFrom((src, dest) =>
                {
                    var attrs = new List<ProductAttributeWithValueDto>(src.ProductAttributeValues?.Count ?? 0);
                    var attrValues = src.ProductAttributeValues;

                    if(attrValues is null)
                    {
                        return attrs;
                    }

                    foreach(var attrValue in attrValues)
                    {
                        var attr = attrValue.ProductAttribute;

                        var attrWithValueDto = new ProductAttributeWithValueDto
                        {
                            Id = attr.Id,
                            Name = attr.Name,
                            GroupName = attr.Group.Name,
                            Type = ClrToTypescriptTypeNameConverter.GetTypescriptTypeName(attr.ClrType),
                        };


                        if(attr.ClrType.Equals(typeof(string).Name, StringComparison.OrdinalIgnoreCase))
                        {
                            attrWithValueDto.Value = attrValue.Value;
                        }
                        else if(attr.ClrType.Equals(typeof(int).Name, StringComparison.OrdinalIgnoreCase))
                        {
                            attrWithValueDto.Value = int.Parse(attrValue.Value);
                        }
                        else if(attr.ClrType.Equals(typeof(float).Name, StringComparison.OrdinalIgnoreCase))
                        {
                            attrWithValueDto.Value = float.Parse(attrValue.Value);
                        }
                        else if(attr.ClrType.Equals(typeof(double).Name, StringComparison.OrdinalIgnoreCase))
                        {
                            attrWithValueDto.Value = double.Parse(attrValue.Value);
                        }
                        else if(attr.ClrType.Equals(typeof(decimal).Name, StringComparison.OrdinalIgnoreCase))
                        {
                            attrWithValueDto.Value = decimal.Parse(attrValue.Value);
                        }
                        else
                        {
                            throw new NotImplementedException("Not implemented CLR type converting.");
                        }


                        attrs.Add(attrWithValueDto);
                    }

                    return attrs;
                }));

            config.CreateMap<ProductWithAdditionalInfoDto, Product>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
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

            config.CreateMap<FromFileProductDto, Product>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.ProductCode, opt => opt.MapFrom(src => src.ProductCode))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price));
        }
    }
}
