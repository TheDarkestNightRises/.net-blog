using System.Text.RegularExpressions;
using Blog.Application.LogicInterfaces;
using Blog.Shared;
using DockerContainer.ImageInformation.Provider.ContainerRegistry.Exceptions;

namespace Blog.Application.Logic;

public class UserLogic : IUserLogic
{
    private readonly IUserDao userDao;

        public UserLogic(IUserDao userDao) {
            this.userDao = userDao;
        }

        public async Task<User> CreateAsync(UserCreationDto userToCreate) {
            User? existing = await userDao.GetByUsernameAsync(userToCreate.Username);
            if (existing != null) throw new InvalidUsernameException("Username is already taken");

            ValidateData(userToCreate);
            User toCreate = new User {
                Username = userToCreate.Username,
               
            };

            User created = await userDao.CreateAsync(toCreate);
            return created;

        }

        public async Task<IEnumerable<User>> GetAsync() {
            throw new NotImplementedException();
        }

        public async Task<User> GetByIdAsync(string id) {
            User? user = await userDao.GetByIdAsync(id);
            if (user != null) return user;

            throw new Exception($"No user with id \"{id}\" was found");
        }

        public async Task<User> GetByUserNameAsync(string userName) { //TODO remove if not needed
            User? user = await userDao.GetByUsernameAsync(userName);
            if (user != null) return user;

            throw new Exception($"No user with name \"{user}\" was found");
        }

        private static void ValidateData(UserCreationDto userCreationDto) {
            string username = userCreationDto.Username;
            if(Regex.Matches(username, "@\"[^A-Za-z_-]\"").Any()) {
                throw new InvalidUsernameException("Username contains invalid characters. Only letters (A-z), numbers, dashes and underscores are allowed");
            }

            if (username.Length < 4) {
                throw new InvalidUsernameException("Username is too short. The minimum length is 4 characters");
            }

            if (username.Length > 20) {
                throw new InvalidUsernameException("Username is too long. The maximum length is 20 characters");
            }
        }

    
}