using Blog.Shared;

namespace Blog.Application;

public interface RegistrInterface
{
    Task<UserDto> CreateAsync(UserDto dto);
}