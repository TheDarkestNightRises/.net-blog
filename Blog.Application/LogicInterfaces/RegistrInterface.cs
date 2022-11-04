using Blog.Shared;

namespace Blog.Application;

public interface RegistrInterface
{
    Task<RegisterDto> CreateAsync(RegisterDto dto);
}