﻿using Blog.Shared;

namespace Blog.BlazorWASM;

public interface IPostService
{
    Task CreateAsync(PostCreationDto dto);
}