﻿using Blog.Shared;
using Blog.Shared.Models;

namespace Blog.Application;

public class PostLogic : IPostLogic
{
    private readonly IPostDao postDao;

    public PostLogic(IPostDao postDao)
    {
        this.postDao = postDao;
    }

    public async Task<PostDto> CreateAsync(PostCreationDto dto)
    {
        //TODO: validate user when login part done
        ValidateCreationDto(dto);
        Post post = new Post(dto.Title, dto.Body, dto.Url, dto.Category, new User(dto.AuthorName, "", ""));
        Post created = await postDao.CreateAsync(post);
        PostDto createdDto = new PostDto(created.Id, created.Title, created.Body, created.Url, created.Category, created.User.Username, created.DateCreated);
        
        return createdDto;
    }

    public async Task<List<Post>> GetAllPostsAsync()
    {
        return await postDao.GetAllAsync();
    }

    public async Task<Post?> GetPostAsync(string url)
    {
        Post? post = await postDao.GetAsync(url);
        if (post is null)
        {
            throw new Exception("Post is not found");
        }
        return post;
    }

    private void ValidateCreationDto(PostCreationDto dto)
    {
        if (string.IsNullOrEmpty(dto.Title)) throw new Exception("Title cannot be empty.");
        if (string.IsNullOrEmpty(dto.Body)) throw new Exception("Post body cannot be empty.");
        if (string.IsNullOrEmpty(dto.Url)) throw new Exception("Url cannot be empty.");
        Post? post = postDao.GetAsync(dto.Url).Result;
        if (post is not null) throw new Exception("Post with this URL already exists");
    }
}