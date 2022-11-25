using System.Text.Json.Serialization;

namespace Blog.Shared.Models;

public class Comment
{
    public int Id { get; set; }

    //Actual user needed
    public User user{ get;  set; }
  
    public Post post{ get; set; }
    
    public string Text { get; set; }
    
    public DateTime DateCreated { get; set; } = DateTime.Now;

    public Comment(User User, Post Post, string Text)
    {
        user = User;
        post = Post;
        this.Text = Text;
    }
    
    public override string ToString()
    {
        return $"{Id} {user} {post} {Text} {DateCreated}";
    }
    public Comment()
    {
    }
}