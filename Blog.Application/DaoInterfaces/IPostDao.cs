using Blog.Shared;

namespace Blog.Application;

public interface IPostDao
{
    Task<Post> CreateAsync(Post post);
    Task<Post?> GetByIdAsync(int postId);
    Task<Post?> GetAsync(string url);
    Task<List<Post>> GetAllAsync();
}