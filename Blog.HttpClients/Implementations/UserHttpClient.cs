using System.Text.Json;
using Blog.Shared;

namespace Blog.BlazorWASM;
using System.Net.Http.Json;

public class UserHttpClient : IUserService
{
    private readonly HttpClient client;

    public UserHttpClient(HttpClient client)
    {
        this.client = client;
    }
    public async Task CreateAsync(UserDto dto)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("/posts",dto);
        if (!response.IsSuccessStatusCode)
        {
            string content = await response.Content.ReadAsStringAsync();
            throw new Exception(content);
        }
    }

    public Task<ICollection<User>> GetListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetElementAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<User> AddElementAsync(User element)
    {
        throw new NotImplementedException();
    }

    public Task DeleteElementAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateElementAsync(User element)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUser(string email)
    {
        throw new NotImplementedException();
    }
}