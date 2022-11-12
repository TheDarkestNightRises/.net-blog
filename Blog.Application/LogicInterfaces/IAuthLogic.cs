using Blog.Shared;
using Elearn.Shared.Dtos;

namespace Elearn.Application.LogicInterfaces;

public interface IAuthLogic
{
    Task<User> ValidateUser(string username, string password);

    Task<User> RegisterUserAsync(UserCreationDto dto);

   
}