using Blog.Application;
using Blog.Shared;
using Blog.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Blog.Data.DAOs;

public class PostDao : IPostDao
{
    private readonly BlogContext context;

    public PostDao(BlogContext context)
    {
        this.context = context;
    }
    public async Task<Post> CreateAsync(Post post)
    {
        EntityEntry<Post> added = await context.Posts.AddAsync(post);
        await context.SaveChangesAsync();
        return added.Entity;
    }

    public async Task<Post?> GetByIdAsync(int postId)
    {
        Post? found = await context.Posts.FindAsync(postId);
        return found;
    }

    public async Task<Post?> GetAsync(string url)
    {
        Post? found = await context.Posts.FindAsync(url);
        return found;
    }

    public async Task<List<Post>> GetAllAsync()
    {
        IQueryable<Post> query = context.Posts.Include(post => post.Id).AsQueryable();
        List<Post> result = await query.ToListAsync();
        return result;
    }
}