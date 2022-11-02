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
}