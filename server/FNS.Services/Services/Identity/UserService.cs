using AutoMapper;
using FNS.Domain.Models.Identity;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.Indentity;
using FNS.Services.Dtos.Identity;
using FNS.Services.Mappers.Identity;
using Microsoft.AspNetCore.Http;

namespace FNS.Services.Services.Identity
{
    internal sealed class UserService : IUserService
    {
        private readonly IRootRepository _rootRepository;
        private readonly IMapper _mapper;

        public UserService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _mapper = new UserMapperConfiguration().Mapper;
        }

        private IRootRepository RootRepository => _rootRepository;

        private IMapper Mapper => _mapper;

        public AppOpResult<IEnumerable<UserDto>> GetAllUsers()
        {
            var users = RootRepository.UsersRepository.GetAll();
            var dtos = Mapper.Map<IEnumerable<UserDto>>(users);

            var result = new AppOpResult<IEnumerable<UserDto>>(dtos);
            return result;
        }

        [Obsolete("For debugging")]
        public async Task<AppOpResult<UserDto>> GetUserByIdAsync(string id, CancellationToken ct = default)
        {
            var user = await RootRepository.UsersRepository.FindByIdAsync(id, ct);

            if(user is null)
            {
                var errResult = new UserNotFoundResult();
                return errResult;
            }

            var dto = Mapper.Map<UserDto>(user);
            var result = new AppOpResult<UserDto>(dto);

            return result;
        }

        private sealed class UserNotFoundResult : AppOpResult<UserDto>
        {
            public UserNotFoundResult()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = $"{typeof(User).Name} not found",
                    Detail = $"{typeof(User).Name} with specified Id is not found",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }
    }
}
