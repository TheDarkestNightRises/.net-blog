using System.ComponentModel.DataAnnotations;

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

    [Required]
    public string Username { get; set; }
    [Required] 
    public string Password { get; set; }
}