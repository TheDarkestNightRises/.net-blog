namespace Blog.Shared.Shared;

public class CommentDto
{
    public int Id { get; set; }
    
    //Actual user needed
    public int AuthorId{ get; set; }
    
    public Post post{ get; set; }
    
    public String Text { get; set; }
    
    public DateTime DateCreated { get; set; } 

    public CommentDto(int authorId, Post post, string text, DateTime dateCreated)
    {
        AuthorId = authorId;
        this.post = post;
        Text = text;
        DateCreated = dateCreated;
    }
    
    public override string ToString()
    {
        return $"{Id} {AuthorId} {post} {Text} {DateCreated}";
    }

}