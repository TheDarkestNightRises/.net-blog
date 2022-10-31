namespace Blog.Shared;

public class PostCreationDto
{
    public string Title{ get; set; }
    public string HtmlBody{ get; set; }
    public string Url{ get; set; }
    public int AuthorId{ get; set; }
    public PostCreationDto(string title, string htmlBody, string url)
    {
        Title = title;
        this.HtmlBody = htmlBody;
        this.Url = url;
    }
    public override string ToString()
    {
        return $"{Title} {HtmlBody} {Url}";
    }
}