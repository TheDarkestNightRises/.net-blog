using Blog.Application.DaoInterfaces;
using Blog.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Blog.Data.DAOs;

public class CommentDao : ICommentDao
{
    private readonly BlogContext context;

    public CommentDao(BlogContext context)
    {
        this.context = context;
    }
    public async Task<Comment> CreateAsync(Comment comment)
    {
        EntityEntry<Comment> added = await context.Comments.AddAsync(comment);
        await context.SaveChangesAsync();
        return added.Entity;
    }

    public async Task<IEnumerable<Comment>> GetAllCommentsByPostUrlAsync(string url)
    {
        IQueryable<Comment> commentsQuery = context.Comments.AsQueryable();
        commentsQuery = commentsQuery.Where(c => c.Post.Url.Equals(url));
        IEnumerable<Comment> result = await commentsQuery.ToListAsync();
        return result;
    }
}