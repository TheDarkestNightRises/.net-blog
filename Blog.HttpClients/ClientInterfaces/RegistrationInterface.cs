using Blog.Shared;

namespace Blog.BlazorWASM;

public interface RegistrationInterface
{
    Task<ServiceResponse<int>> Register(RegisterDto request);

}