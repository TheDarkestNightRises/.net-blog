namespace Blog.Shared.Models;

public class Comment
{
    public int Id { get; set; }
    
    //Actual user needed
    public User Author{ get; set; }
    
    public Post post{ get; set; }
    
    public string Text { get; set; }
    
    public DateTime DateCreated { get; set; } = DateTime.Now;

    public Comment(User author, Post post, string Text)
    {
        Author = author;
        this.post = post;
        this.Text = Text;
    }
    
    public override string ToString()
    {
        return $"{Id} {Author} {post} {Text} {DateCreated}";
    }

}