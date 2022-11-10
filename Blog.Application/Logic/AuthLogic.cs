using System.ComponentModel.DataAnnotations;
using Blog.Application;
using Blog.Shared;
using Elearn.Application.LogicInterfaces;

namespace Elearn.Application.Logic;

public class AuthLogic : IAuthLogic
{
    private readonly IUserDao userDao;
    public AuthLogic(IUserDao userDao) {
        this.userDao = userDao;
    }

    public async Task<User> ValidateUser(string username, string password) 
    {
        User? existingUser = await userDao.GetByUsernameAsync(username);

        if (existingUser == null) {
            throw new Exception("User not found");
        }

        if (!existingUser.Equals(password)) {
            throw new Exception("Password mismatch");
        }

        return existingUser;
    }

    public Task RegisterUser(User user) 
    {

        if (string.IsNullOrEmpty(user.Username)) {
            throw new ValidationException("Username cannot be null");
        }


        userDao.CreateAsync(user);

        return Task.CompletedTask;
    }

    public async Task<User> RegisterUserAsync(UserCreationDto dto)
    {
        if (string.IsNullOrEmpty(dto.Username))
        {
            throw new ValidationException("Username cannot be null");
        }
        if (string.IsNullOrEmpty(dto.Password))
        {
            throw new ValidationException("Password cannot be null");
        }
        if (string.IsNullOrEmpty(dto.Email))
        {
            throw new ValidationException("Email cannot be null");
        }
        if (string.IsNullOrEmpty(dto.Name))
        {
            throw new ValidationException("Name cannot be null");
        }
        User user = new User(dto.Username, dto.Password, dto.Email, dto.Name, dto.Role, dto.SecurityLevel);
        User created = await userDao.CreateNewUserAsync(user);
        return created;
    }
}