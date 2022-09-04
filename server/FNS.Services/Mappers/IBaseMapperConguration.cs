using AutoMapper;

namespace FNS.Services.Mappers
{
    internal interface IBaseMapperConguration
    {
        public IMapper Mapper { get; }
    }
}