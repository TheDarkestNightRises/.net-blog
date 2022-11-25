using System.Text.Json.Serialization;

namespace Blog.Shared.Models;

public class Comment
{
    public int Id { get; set; }

    //Actual user needed
    public User User{ get;  set; }
  
    public Post Post{ get; set; }
    
    public string Text { get; set; }
    
    public DateTime DateCreated { get; set; } = DateTime.Now;

    public Comment(User User, Post Post, string Text)
    {
        this.User = User;
        this.Post = Post;
        this.Text = Text;
    }
    
    public override string ToString()
    {
        return $"{Id} {User} {Post} {Text} {DateCreated}";
    }
    public Comment()
    {
    }
}