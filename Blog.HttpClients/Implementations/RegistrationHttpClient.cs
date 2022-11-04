using Blog.Shared;

namespace Blog.BlazorWASM;
using System.Net.Http.Json;

public class RegistrationHttpClient : RegistrationInterface
{
    private readonly HttpClient _http;

    public RegistrationHttpClient(HttpClient http)
    {
        _http = http;
    }

    public async Task<ServiceResponse<int>> Register(UserRegister request)
    {
        var result = await _http.PostAsJsonAsync("api/auth/register", request);
        return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
    }

    public Task<ServiceResponse<int>> Register(RegisterDto request)
    {
        throw new NotImplementedException();
    }
}