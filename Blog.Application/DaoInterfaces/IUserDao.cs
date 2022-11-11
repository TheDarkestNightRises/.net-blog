using Blog.Shared;

namespace Blog.Application;

public interface IUserDao
{
    Task<User> CreateAsync(User user);
    Task<User?> GetByIdAsync(int id);
    Task<User?> GetByUsernameAsync(string userName);
}