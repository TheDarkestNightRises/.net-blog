using Blog.Shared.Models;

namespace Blog.Shared;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public string Url { get; set; }
    public string Category { get; set; }
    public User User { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;

    public Post(int id, string title, string body, string url, string category, User user)
    {
        Id = id;
        Title = title;
        Body = body;
        Url = url;
        Category = category;
        User = user;
    }

    public Post(string title, string body, string url, string category, User user)
    {
        Title = title;
        Body = body;
        Url = url;
        Category = category;
        User = user;
    }

    public Post()
    {
    }

    public override string ToString()
    {
        return $"{Id} {Title} {Body} {Url}";
    }
}