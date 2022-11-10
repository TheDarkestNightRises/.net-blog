using Blog.Shared.Models;

namespace Blog.Application.DaoInterfaces;

public interface ICommentDao
{
    Task<Comment> CreateAsync(Comment comment);
    Task<IEnumerable<Comment>> GetAllCommentsByPostUrlAsync(string url);
}