namespace Blog.Shared;

public class PostDto
{
    public int Id { get; set; }
    public string Title{ get; set; }
    public string HtmlBody{ get; set; }
    public string Url{ get; set; }
    public int AuthorId{ get; set; }

    public PostDto(int id, string title, string htmlBody, string url)
    {
        Id = id;
        Title = title;
        HtmlBody = htmlBody;
        Url = url;
    }

    public override string ToString()
    {
        return $"{Id} {Title} {HtmlBody} {Url}";
    }
}