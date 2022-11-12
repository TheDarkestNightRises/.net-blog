using Blog.Shared.Models;

namespace Blog.Shared;

public class Post
{
    public int Id { get; set; }
    public string Title{ get; set; }
    public string Body{ get; set; }
    public string Url{ get; set; }
    public string Category { get; set; }
    public User Author{ get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;

    public Post(string title, string body, string url, string category, User author)
    {
        Title = title;
        Body = body;
        Url = url;
        this.Category = category;
        this.Author = author;
    }

    public override string ToString()
    {
        return $"{Id} {Title} {Body} {Url}";
    }
    
}