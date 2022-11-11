using System.Security.Claims;
using Blog.Shared;
using Elearn.Shared.Dtos;


namespace Elearn.HttpClients.Service;

public interface IAuthService
{
    public Task LoginAsync(UserLoginDto userLoginDto);
    public Task LogoutAsync();
    public Task RegisterAsync(UserCreationDto user);
    public Task<ClaimsPrincipal> GetAuthAsync();

    public Action<ClaimsPrincipal> OnAuthStateChanged { get; set; }

}