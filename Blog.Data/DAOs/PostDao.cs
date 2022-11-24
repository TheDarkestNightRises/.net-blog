using Blog.Application;
using Blog.Shared;

namespace Blog.Data.DAOs;

public class PostDao : IPostDao
{
    public Task<Post> CreateAsync(Post post)
    {
        throw new NotImplementedException();
    }

    public Task<Post?> GetByIdAsync(int postId)
    {
        throw new NotImplementedException();
    }

    public Task<Post?> GetAsync(string url)
    {
        throw new NotImplementedException();
    }

    public Task<List<Post>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}