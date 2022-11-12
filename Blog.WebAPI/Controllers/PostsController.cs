using Blog.Application;
using Blog.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebAPI.Controllers;

[ApiController]
[Route("posts")]
public class PostsController : ControllerBase
{
    private readonly IPostLogic postLogic;

    public PostsController(IPostLogic postLogic)
    {
        this.postLogic = postLogic;
    }

    [HttpPost]
    public async Task<ActionResult<PostDto>> CreateAsync([FromBody] PostCreationDto dto)
    {
        try
        {
            PostDto createdDto = await postLogic.CreateAsync(dto);
            return Created($"/posts/{createdDto.Url}", createdDto);// ???
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Post>>> GetAllPostsAsync()
    {
        try
        {
            var posts = await postLogic.GetAllPostsAsync();
            return Ok(posts);
        }
        catch (Exception e)
        {
            Console.WriteLine(e); 
            return StatusCode(500, e.Message);
        }
   
    }

    [HttpGet("{url}")]
    public async Task<ActionResult<Post>> GetBlogPostAsync(string url)
    {
        try
        {
            var post = await postLogic.GetPostAsync(url);
            if (post is null)
            {
                return NotFound("This post does not exist");
            }
            return Ok(post);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    
    }

}