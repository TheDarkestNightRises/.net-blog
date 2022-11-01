using Blog.Shared;

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
        Post post = new Post(dto.Title, dto.Body, dto.Url, dto.Category, dto.AuthorId);
        Post created = await postDao.CreateAsync(post);
        PostDto createdDto = new PostDto(created.Id, created.Title, created.Body, created.Url, created.category, created.authorId, created.DateCreated);
        
        return createdDto;
    }

    private void ValidateCreationDto(PostCreationDto dto)
    {
        if (string.IsNullOrEmpty(dto.Title)) throw new Exception("Title cannot be empty.");
        if (string.IsNullOrEmpty(dto.Body)) throw new Exception("Post body cannot be empty.");
        if (string.IsNullOrEmpty(dto.Url)) throw new Exception("Url cannot be empty.");
    }
}