namespace Blog.Shared;

public class PostDto
{
    public int Id { get; set; }
    public string Title{ get; set; }
    public string Body{ get; set; }
    public string Url{ get; set; } 
    public string Category { get; set; }
    public int AuthorId{ get; set; }
    public DateTime DateCreated { get; set; }

    public PostDto(int id, string title, string body, string url, string category, int authorId, DateTime dateCreated)
    {
        Id = id;
        Title = title;
        Body = body;
        Url = url;
        Category = category;
        AuthorId = authorId;
        DateCreated = dateCreated;
    }

    public override string ToString()
    {
        return $"{Id} {Title} {Body} {Url}";
    }
}