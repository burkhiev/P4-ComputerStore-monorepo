using AutoMapper;
using FNS.Domain.Models.Purchases;
using FNS.Services.Dtos.Purchases;

namespace FNS.Services.Mappers.Purchases
{
    internal sealed class PurchasesMapperConfiguration : IBaseMapperConguration
    {
        private readonly MapperConfiguration _config;

        public PurchasesMapperConfiguration()
        {
            _config = new MapperConfiguration(config => Configure(config));
        }

        public IMapper Mapper => _config.CreateMapper();

        private void Configure(IMapperConfigurationExpression config)
        {
            config.CreateMap<PurchaseInvoice, PurchaseInvoiceDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt));

            config.CreateMap<PurchaseInvoiceItem, PurchaseInvoiceItemDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PurchaseInvoiceId, opt => opt.MapFrom(src => src.PurchaseInvoiceId))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount));

            config.CreateMap<PurchaseInvoiceItem, PurchaseInvoiceItemWithAdditionalInfoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PurchaseInvoiceId, opt => opt.MapFrom(src => src.PurchaseInvoiceId))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name))
                .ForMember(dest => dest.ProductCode, opt => opt.MapFrom(src => src.Product.ProductCode))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount));
        }
    }
}
