namespace Blog.Shared;

public class User
{
    public String Id { get; set; } = IdRandom.GetRandomID(20);
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String Email { get; set; }
    public String Password { get; set; }
    public String RepeatPassword { get; set; }

    public User()
    {
         
        FirstName = String.Empty;
        LastName = String.Empty;
        Email = String.Empty;
        Password = String.Empty;
        RepeatPassword = String.Empty;
    }

   
}