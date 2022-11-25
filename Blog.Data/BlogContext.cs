using Blog.Shared;
using Blog.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data;

public class BlogContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = ../EfcDataAccess/Blog.db");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>().HasKey(post => post.Id);
        modelBuilder.Entity<User>().HasKey(user => user.UserId);
        modelBuilder.Entity<Comment>().HasKey(comment => comment.Id);
   
    }
}