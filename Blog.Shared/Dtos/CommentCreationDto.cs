namespace Blog.Shared.Shared;

public class CommentCreationDto
{
    //Actual user needed
    public String Text { get; set; }
    
    public int PostId{ get; set; }
    
    public int UserId{ get; set; }

    public CommentCreationDto(int userId, int postId, string text)
    {
        UserId = userId;
        PostId = postId;
        Text = text;
    }
    
    public override string ToString()
    {
        return  $"{Text}";
    }

}