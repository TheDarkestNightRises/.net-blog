using System.Text;

namespace Blog.Shared;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
    public int SecurityLevel { get; set; }

    public User(string username, string password, string email, string name, string role, int securityLevel)
    {
        Username = username;
        Password = password;
        Email = email;
        Name = name;
        Role = role;
        SecurityLevel = securityLevel;
    }

    public User(string username, string password, string email)
    {
        Username = username;
        Password = password;
        Email = email;
    }

    public User()
    {
    }

    public override string ToString()
    {
        return $"{UserId} {Username} {Password} {Email} {Name} {Role} {SecurityLevel} ";
    }
}

