using Blog.Shared;

namespace Blog.BlazorWASM;

public interface IUserService : IGenericService<User,String>
{
   public Task<User> GetUser(String email);

}