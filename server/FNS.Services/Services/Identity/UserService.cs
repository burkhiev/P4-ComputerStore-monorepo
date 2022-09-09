using AutoMapper;
using FNS.Domain.Models.Identity;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.Indentity;
using FNS.Services.Dtos;
using FNS.Services.Dtos.Identity;
using FNS.Services.Mappers.Identity;
using NodaTime;

namespace FNS.Services.Services.Identity
{
    internal sealed class UserService : IUsersService
    {
        private readonly IRootRepository _rootRepository;
        private readonly IMapper _mapper;

        public UserService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _mapper = new UserMapperConfiguration().Mapper;
        }

        private IRootRepository RootRepo => _rootRepository;
        private IMapper Mapper => _mapper;

        //public async Task<OpResult<EmptyDto>> MarkAsAttendedAsync(string userId)
        //{
        //    var user = await RootRepo.Users.FindByIdAsync(userId);

        //    if(user is null)
        //    {
        //        var notFound = new NotFoundResult<EmptyDto>(typeof(User));
        //        return notFound;
        //    }

        //    var now = DateTime.UtcNow;
        //    user.LastActionAt = Instant.FromDateTimeUtc(now);

        //    await RootRepo.SaveChangesAsync();

        //    var result = new OpResult<EmptyDto>();
        //    return result;
        //}

        public OpResult<IEnumerable<UserDto>> GetAllUsers()
        {
            var users = RootRepo.Users.GetAll();
            var dtos = Mapper.Map<IEnumerable<UserDto>>(users);

            var result = new OpResult<IEnumerable<UserDto>>(dtos);
            return result;
        }

        public async Task<OpResult<UserDto>> GetUserByIdAsync(string id)
        {
            var user = await RootRepo.Users.FindByIdAsync(id);

            if(user is null)
            {
                var errResult = new NotFoundResult<UserDto, User>();
                return errResult;
            }

            var dto = Mapper.Map<UserDto>(user);
            var result = new OpResult<UserDto>(dto);

            return result;
        }
    }
}
