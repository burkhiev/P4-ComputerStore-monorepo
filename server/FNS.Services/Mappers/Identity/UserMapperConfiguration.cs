using AutoMapper;
using FNS.Domain.Models.Identity;
using FNS.Services.Dtos.Identity;

namespace FNS.Services.Mappers.Identity
{
    internal sealed class UserMapperConfiguration : IBaseMapperConguration
    {
        private readonly MapperConfiguration _mapperConfiguration;

        public UserMapperConfiguration()
        {
            _mapperConfiguration = new MapperConfiguration(config => Configure(config));
        }

        public IMapper Mapper => _mapperConfiguration.CreateMapper();

        private void Configure(IMapperConfigurationExpression config)
        {
            config.CreateMap<User, UserDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ConcurrencyToken, opt => opt.MapFrom(src => src.ConcurrencyToken))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.GetType().Name));
        }
    }
}
