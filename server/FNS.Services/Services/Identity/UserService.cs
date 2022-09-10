using AutoMapper;
using FNS.Domain.Exceptions;
using FNS.Domain.Models.Identity;
using FNS.Domain.Models.ShoppingCarts;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.Indentity;
using FNS.Services.Dtos;
using FNS.Services.Dtos.Identity;
using FNS.Services.Mappers.Identity;
using FNS.Services.Utils.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NodaTime;

namespace FNS.Services.Services.Identity
{
    internal sealed class UserService : IUsersService
    {
        public const int MaxUsersCount = 50;

        private readonly IRootRepository _rootRepository;
        private readonly IMapper _mapper;

        public UserService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _mapper = new UserMapperConfiguration().Mapper;
        }

        private IRootRepository RootRepo => _rootRepository;
        private IMapper Mapper => _mapper;

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

        public async Task<OpResult<UserDto>> CreateUserAsync(UserManager<User> userManager, RegisterDto dto)
        {
            // проверка пароля
            if(dto.Password != dto.ConfirmPassword)
            {
                string detail = $"{nameof(dto.Password)} and {nameof(dto.ConfirmPassword)} are not equal.";
                var notCreated = new InvalidRegisterResult<UserDto>(detail);
                return notCreated;
            }


            // проверка Email
            var users = RootRepo.Users.GetAll();
            var hasUserWithEmail = users.Any(x => x.Email == dto.Email);

            if(hasUserWithEmail)
            {
                string detail = $"User with specified {nameof(dto.Email)} already exists.";
                var notCreated = new InvalidRegisterResult<UserDto>(detail);
                return notCreated;
            }


            // проверка UserName
            var hasUserWithUserName = users.Any(x => x.UserName == dto.UserName);

            if(hasUserWithUserName)
            {
                string detail = $"User with specified {nameof(dto.UserName)} already exists.";
                var notCreated = new InvalidRegisterResult<UserDto>(detail);
                return notCreated;
            }


            // Ограничение на создания пользователей
            //
            // TODO:
            //   Написать создание отметки времени последнего
            // действия пользователя, отправленного на сервер.
            //   В этом месте, на основе указанных отметок, написать
            // удаление пользователей, с наиболее старым последним действием.
            var usersCount = RootRepo.Users.GetAll().Count();

            if(usersCount > MaxUsersCount)
            {
                var tooMany = new InvalidRegisterResult<UserDto>("Registered users count has reached max value.");
            }


            // создание пользователя
            var newUser = new User
            {
                Id = Guid.NewGuid().ToString(),
                Email = dto.Email,
                UserName = dto.UserName,
            };

            var createResult = await userManager.CreateAsync(newUser);

            if(createResult.Succeeded)
            {
                // установка пароля для пользователя
                var addPasswordResult = await userManager.AddPasswordAsync(newUser, dto.Password);

                if(addPasswordResult.Succeeded)
                {
                    // добавление пользователю роли по умолчанию
                    var addToRoleResult = await userManager.AddToRoleAsync(newUser, AppRoleNames.User);

                    if(addToRoleResult.Succeeded)
                    {
                        // создание покупательской корзины для пользователя
                        var cart = new ShoppingCart
                        {
                            Id = Guid.NewGuid().ToString(),
                            UserId = newUser.Id,
                        };

                        await RootRepo.ShoppingCarts.AddAsync(cart);
                    }
                    else
                    {
                        await RemoveUserAsync(userManager, newUser);
                        var invalidResult = GetInvalidValidationResult<UserDto>(createResult);
                        return invalidResult;
                    }
                }
                else
                {
                    await RemoveUserAsync(userManager, newUser);
                    var invalidResult = GetInvalidValidationResult<UserDto>(createResult);
                    return invalidResult;
                }
            }
            else
            {
                var invalidResult = GetInvalidValidationResult<UserDto>(createResult);
                return invalidResult;
            }


            // ***** ВАЖНО *****
            //
            // Данный блок try/catch не отлавливает исключения, возникающие
            // при создании пользователя или при добавлении пользователя в роль!!!
            try
            {
                await RootRepo.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                await RemoveUserAsync(userManager, newUser);
                var fault = new InvalidDbConcurrencyUpdateResult<UserDto>();
                return fault;
            }
            catch(DbUpdateException ex)
            {
                await RemoveUserAsync(userManager, newUser);
                var fault = new InvalidDbUpdateResult<UserDto>();
                return fault;
            }


            var newUserDto = Mapper.Map<UserDto>(newUser);
            var result = new OpResult<UserDto>(newUserDto);

            return result;


            async Task RemoveUserAsync(UserManager<User> userManager, User user)
            {
                if(user is null || string.IsNullOrWhiteSpace(user.Id))
                {
                    return;
                }

                var deleteUserResult = await userManager.DeleteAsync(user);

                if(!deleteUserResult.Succeeded)
                {
                    throw new UnknownException();
                }
            }
        }

        private InvalidValidationResult<T> GetInvalidValidationResult<T>(IdentityResult result)
        {
            var invalidResult = new InvalidValidationResult<T>();

            if(!result.Succeeded)
            {
                var errors = new Dictionary<string, string>();

                foreach(var error in result.Errors)
                {
                    errors.Add(error.Code, error.Description);
                }

                invalidResult.FailResult.Errors = errors;
            }

            return invalidResult;
        }

        public async Task<OpResult<EmptyDto>> DeleteUserAsync(UserManager<User> userManager, UserDeletingDto dto)
        {
            // подтверждение пароля
            if(dto.Password != dto.ConfirmPassword)
            {
                var notConfirmed = new InvalidUserDeletingResult<EmptyDto>("Password fields are not equal.");
                return notConfirmed;
            }


            // ищем пользователя
            var user = await RootRepo.Users.FindByIdAsync(dto.Id);

            if(user is null)
            {
                var notFound = new NotFoundResult<EmptyDto, User>();
                return notFound;
            }


            // проверяем пароль
            bool passwordIsCorrect = await userManager.CheckPasswordAsync(user, dto.Password);

            if(passwordIsCorrect)
            {
                // удаление пользователя
                var deleteResult = await userManager.DeleteAsync(user);

                if(!deleteResult.Succeeded)
                {
                    throw new UnknownException();
                }
            }
            else
            {
                var invalidPassword = new InvalidUserDeletingResult<EmptyDto>("Invalid password.");
                return invalidPassword;
            }


            var result = new OpResult<EmptyDto>();
            return result;
        }

        private sealed class InvalidRegisterResult<T> : OpResult<T>
        {
            public InvalidRegisterResult(string detail) : base()
            {
                FailResult = new ProblemResultInfo
                {
                    Title = "New user not created",
                    Detail = detail ?? "Invalid user's data received.",
                    StatusCode = StatusCodes.Status400BadRequest
                };
            }
        }

        private sealed class InvalidUserDeletingResult<T> : OpResult<T>
        {
            public InvalidUserDeletingResult(string? detail) : base()
            {
                FailResult = new ProblemResultInfo
                {
                    Title = "User is not deleted",
                    Detail = detail ?? "Something went wrong.",
                    StatusCode = StatusCodes.Status400BadRequest,
                };
            }
        }
    }
}
