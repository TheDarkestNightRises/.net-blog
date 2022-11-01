namespace Blog.Shared;

public class Post
{
    public int Id { get; set; }
    public string Title{ get; set; }
    public string Body{ get; set; }
    public string Url{ get; set; }
    public string category { get; set; }
    public int authorId{ get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;

    public Post(string title, string body, string url, string category, int authorId)
    {
        Title = title;
        Body = body;
        Url = url;
        this.category = category;
        this.authorId = authorId;
    }

    public override string ToString()
    {
        return $"{Id} {Title} {Body} {Url}";
    }
    
}