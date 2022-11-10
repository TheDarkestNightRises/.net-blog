using Blog.Shared;

namespace Blog.Application;

public interface IUserDao
{
    Task<User> CreateAsync(User user);
    Task<User?> GetByIdAsync(string id);
    Task<User?> GetByUsernameAsync(string userName);
    Task<User> CreateNewUserAsync(User user);
}