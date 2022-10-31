namespace Blog.Shared;

public class Post
{
    public int Id { get; set; }
    public string Title{ get; set; }
    public string HtmlBody{ get; set; }
    public string Url{ get; set; }
    public string category { get; set; }
    public int authorId{ get; set; }

    public Post(string title, string htmlBody, string url)
    {
        Title = title;
        this.HtmlBody = htmlBody;
        this.Url = url;
    }
    public override string ToString()
    {
        return $"{Id} {Title} {HtmlBody} {Url}";
    }
    
}