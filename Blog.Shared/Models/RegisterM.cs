namespace Blog.Shared;

public class RegisterM
{
    public int Id { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String Email { get; set; }
    public String Password { get; set; }
    public String RepeatPassword { get; set; }

    public RegisterM(int id, string firstName, string lastName, string email, string password, string repeatPassword)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        RepeatPassword = repeatPassword;
    }

   
}