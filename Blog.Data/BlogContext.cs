using Blog.Shared;
using Blog.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data;

public class BlogContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = ../EfcDataAccess/Blog.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>().HasKey(post => post.Id);
        modelBuilder.Entity<User>().HasKey(user => user.UserId);
        modelBuilder.Entity<Comment>().HasKey(comment => comment.Id);
        modelBuilder.Entity<Post>()
            .HasOne(p => p.User)
            .WithMany();
        modelBuilder.Entity<Comment>()
            .HasOne(c => c.Post)
            .WithMany();
        modelBuilder.Entity<Post>()
            .HasIndex(p => p.Url)
            .IsUnique();
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Post> Posts { get; set; }
}