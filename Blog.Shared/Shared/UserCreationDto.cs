using System.ComponentModel.DataAnnotations;

namespace Blog.Shared;

public class UserDto
{
    [Required]
    public String Id { get; set; }
    public string FirstName { get; set; } = String.Empty;

    [Required]
    public string LastName { get; set; } = String.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = String.Empty;

    [Required, StringLength(maximumLength:18,MinimumLength = 6)]
    public string Password { get; set; } = String.Empty;

    [Compare("Password",ErrorMessage = "The password does not mathch!"),]
    public string ConfirmPassword { get; set; } = String.Empty;

    public UserDto(String id, String firstName, String lastName, String email, String password, String confirmPassword)
    {
        Id = id;
        this.Email = email;
        this.Password = password;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.ConfirmPassword = confirmPassword;
    }
}