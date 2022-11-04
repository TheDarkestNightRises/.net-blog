using System.Net.Http.Json;
using System.Text.Json;
using Blog.Shared.Models;
using Blog.Shared.Shared;

namespace Blog.BlazorWASM;

public class CommentHttpClient : ICommentService
{
    private readonly HttpClient client;

    public CommentHttpClient(HttpClient client)
    {
        this.client = client;
    }

    public async Task<Comment> Create(CommentCreationDto dto)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("/comments", dto);
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }

        Comment comment = JsonSerializer.Deserialize<Comment>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return comment;
    }
}