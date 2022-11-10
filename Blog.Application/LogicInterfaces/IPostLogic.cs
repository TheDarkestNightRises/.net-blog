using Blog.Shared;

namespace Blog.Application;

public interface IPostLogic
{
    Task<PostDto> CreateAsync(PostCreationDto dto);
    Task<List<Post>> GetAllPostsAsync();
    Task<Post?> GetPostAsync(string url);
}