namespace Blog.Shared.Shared;

public class CommentDto
{
    public int Id { get; set; }
    
    //Actual user needed
    public int AuthorId{ get; set; }
    
    public int postId{ get; set; }
    
    public String Text { get; set; }
    
    public DateTime DateCreated { get; set; } 

    public CommentDto(int authorId, int postId, string text, DateTime dateCreated)
    {
        AuthorId = authorId;
        this.postId = postId;
        Text = text;
        DateCreated = dateCreated;
    }
    
    public override string ToString()
    {
        return $"{Id} {AuthorId} {postId} {Text} {DateCreated}";
    }

}