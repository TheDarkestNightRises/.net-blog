﻿using Blog.Shared;

namespace Blog.Application;

public interface IPostDao
{
    Task<Post> CreateAsync(Post post);
}