using System.ComponentModel.DataAnnotations;

namespace Blog.Shared;

public class UserRegister
{
    [Required]
    public string FirstName { get; set; } = String.Empty;

    [Required]
    public string LastName { get; set; } = String.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = String.Empty;

    [Required, StringLength(maximumLength:18,MinimumLength = 6)]
    public string Password { get; set; } = String.Empty;

    [Compare("Password",ErrorMessage = "The password does not mathch!"),]
    public string ConfirmPassword { get; set; } = String.Empty;
}