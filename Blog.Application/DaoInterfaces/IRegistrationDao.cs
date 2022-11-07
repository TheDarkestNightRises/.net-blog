using Blog.Shared;

namespace Blog.Application;

public interface IRegistrationDao
{
    Task<User> CreateAsync(User register);
}