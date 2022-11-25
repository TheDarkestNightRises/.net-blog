using Blog.Application;
using Blog.Shared;
using Blog.Shared.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Blog.Data.DAOs;

public class UserDao : IUserDao
{
    private readonly BlogContext context;

    public UserDao(BlogContext context)
    {
        this.context = context;
    }
    public async Task<User> CreateAsync(User user)
    {
        EntityEntry<User> added = await context.Users.AddAsync(user);
        await context.SaveChangesAsync();
        return added.Entity;
    }

    public async Task<User?> GetByIdAsync(int id)
    {
        User? found = await context.Users.FindAsync(id);
        return found;
    }

    public async Task<User?> GetByUsernameAsync(string userName)
    {
        User? found = await context.Users.FindAsync(userName);
        return found;
    }
}