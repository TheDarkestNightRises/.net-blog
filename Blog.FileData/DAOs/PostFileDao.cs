using Blog.Application;
using Blog.Shared;
using Blog.Shared.Models;

namespace Blog.FileData;

public class PostFileDao : IPostDao
{
    private readonly FileContext context;
    public PostFileDao(FileContext context)
    {
        this.context = context;
    }

    public Task<Post> CreateAsync(Post post)
    {
        int id = 1;
        if (context.Posts.Any())
        {
            id = context.Posts.Max(t => t.Id);
            id++;
        }

        post.Id = id;
        
        context.Posts.Add(post);
        context.SaveChanges();

        return Task.FromResult(post);
    }

    public Task<Post?> GetByIdAsync(int postId)
    {
        Post? existing = context.Posts.FirstOrDefault(p => p.Id == postId);
        return Task.FromResult(existing);
    }
}