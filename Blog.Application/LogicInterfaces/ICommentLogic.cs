using Blog.Shared;
using Blog.Shared.Models;
using Blog.Shared.Shared;

namespace Blog.Application;

public interface ICommentLogic
{
    Task<Comment> CreateAsync(CommentCreationDto dto);
    
    Task<IEnumerable<Comment>> GetAsync(SearchCommentParametersDto searchParameters);
    
    Task DeleteAsync(int id);
}