﻿using Blog.Shared;

namespace Blog.Application.LogicInterfaces;

public interface IUserLogic
{
    Task<User> CreateAsync(UserCreationDto userToCreate);
    Task<User> GetByIdAsync(int id);
    Task<User> GetByUserNameAsync(string userName);
    Task<IEnumerable<User>> GetAsync();
}