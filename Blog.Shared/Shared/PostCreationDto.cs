namespace Blog.Shared;

public class PostCreationDto
{
    public string Title{ get; set; }
    public string Body{ get; set; }
    public string Url{ get; set; }
    public string Category { get; set; }
    public int AuthorId{ get; set; }

    public PostCreationDto(string title, string body, string url, string category, int authorId)
    {
        Title = title;
        Body = body;
        Url = url;
        Category = category;
        AuthorId = authorId;
    }

    public override string ToString()
    {
        return $"{Title} {Body} {Url}";
    }
}