using Blog.Shared;

namespace Blog.Application;

public class RegistrationLogic : RegistrInterface
{
    private readonly IRegistrationDao registrationDao;
    public RegistrationLogic(IRegistrationDao registrationDao)
    {
        this.registrationDao = registrationDao;
    }
    public Task<UserDto> CreateAsync(UserDto dto)
    {
        throw new NotImplementedException();
    }
    
    private void ValidateCreationDto(UserDto dto)
    {
        if (string.IsNullOrEmpty(dto.FirstName)) throw new Exception("First name field cannot be empty.");
        if (string.IsNullOrEmpty(dto.LastName)) throw new Exception("Last name field cannot be empty.");
        if (string.IsNullOrEmpty(dto.Email)) throw new Exception("Email field cannot be empty.");
        if (string.IsNullOrEmpty(dto.Password)) throw new Exception("Password field cannot be empty.");
        if (string.IsNullOrEmpty(dto.ConfirmPassword)) throw new Exception("Confirmation password field cannot be empty.");


    }


    
}