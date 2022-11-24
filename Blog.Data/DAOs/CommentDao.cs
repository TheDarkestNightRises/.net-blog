using Blog.Application.DaoInterfaces;
using Blog.Shared.Models;

namespace Blog.Data.DAOs;

public class CommentDao : ICommentDao
{
    public Task<Comment> CreateAsync(Comment comment)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Comment>> GetAllCommentsByPostUrlAsync(string url)
    {
        throw new NotImplementedException();
    }
}