using Blog.Application.DaoInterfaces;
using Blog.Shared.Models;

namespace Blog.FileData.DAOs;

public class CommentFileDao : ICommentDao
{
    private readonly FileContext context;


    public CommentFileDao(FileContext context)
    {
        this.context = context;
    }

    public Task<Comment> CreateAsync(Comment comment)
    {
        int id = 1;
        if (context.Comments.Any())
        {
            id = context.Comments.Max(c => c.Id);
            id++;
        }

        comment.Id = id;

        context.Comments.Add(comment);
        context.SaveChanges();

        return Task.FromResult(comment);
    }
}