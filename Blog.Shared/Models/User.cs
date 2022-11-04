namespace Blog.Shared.Models;

public class User
{
    public int Id { get; set; }
    
    //Actual user needed
    public string Username{ get; set; }
    
    public string Password{ get; set; }
    
    public string Email { get; set; }

    public User(string username, string password, string email)
    {
        Username = username;
        Password = password;
        Email = email;
    }
}

