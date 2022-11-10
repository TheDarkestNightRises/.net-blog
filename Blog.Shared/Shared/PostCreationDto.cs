namespace Blog.Shared;

public class PostCreationDto
{
    public string Title{ get; set; }
    public string Body{ get; set; }
    public string Url{ get; set; }
    public string Category { get; set; }
    public string AuthorName{ get; set; }

    public PostCreationDto(string title, string body, string url, string category, string authorName)
    {
        Title = title;
        Body = body;
        Url = url;
        Category = category;
        AuthorName = authorName;
    }

    public override string ToString()
    {
        return $"{Title} {Body} {Url}";
    }
}