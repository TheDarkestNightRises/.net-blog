using Blog.Shared;

namespace Blog.Application;

public interface IRegistrationDao
{
    Task<RegisterM> CreateAsync(RegisterM register);
}