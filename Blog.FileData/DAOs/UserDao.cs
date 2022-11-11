using Blog.Application;
using Blog.Shared;

namespace Blog.FileData.DAOs;

public class UserDao : IUserDao
{
    private readonly FileContext context;


    public UserDao(FileContext context)
    {
        this.context = context;
    }

    public Task<User> CreateAsync(User user)
    {
        int id = 1;
        if (context.User.Any())
        {
            id = context.User.Max(u => u.UserId);
            id++;
        }

        user.UserId = id;

        context.User.Add(user);
        context.SaveChanges();

        return Task.FromResult(user);
    }

    public Task<User?> GetByIdAsync(int id)
    {
        User? existing = context.User.FirstOrDefault(u => u.UserId == id);
        return Task.FromResult(existing);
    }

    public Task<User?> GetByUsernameAsync(string userName)
    {
        User? existing = context.User.FirstOrDefault(u => u.Name == userName);
        return Task.FromResult(existing);
    }
}   