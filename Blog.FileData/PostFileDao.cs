using Blog.Application;
using Blog.Shared;

namespace Blog.FileData;

public class PostFileDao : IPostDao
{
    private int Id = 0;
    public Task<Post> CreateAsync(Post post)
    {
        Id++;
        post.Id = Id;
        Console.WriteLine("Post created: " + post);
        return Task.FromResult(post);
    }
}