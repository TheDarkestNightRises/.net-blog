namespace Blog.Shared.Models;

public class Comment
{
    public int Id { get; set; }
    
    //Actual user needed
    public int AuthorId{ get; set; }
    
    public Post post{ get; set; }
    
    public String Text { get; set; }
    
    public DateTime DateCreated { get; set; } = DateTime.Now;

    public Comment(int authorId, Post post, string Text)
    {
        AuthorId = authorId;
        this.post = post;
        this.Text = Text;
    }
    
    public override string ToString()
    {
        return $"{Id} {AuthorId} {post} {Text} {DateCreated}";
    }

}