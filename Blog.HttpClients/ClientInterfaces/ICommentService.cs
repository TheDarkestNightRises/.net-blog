using Blog.Shared.Models;
using Blog.Shared.Shared;

namespace Blog.BlazorWASM;

public interface ICommentService
{
    Task<Comment> Create(CommentCreationDto dto);
}