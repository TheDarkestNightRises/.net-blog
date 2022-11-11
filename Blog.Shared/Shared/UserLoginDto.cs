namespace Elearn.Shared.Dtos;

public class UserLoginDto
{
    public UserLoginDto(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public UserLoginDto()
    {
    }

    public string Username { get; set; }
    public string Password { get; set; }
}