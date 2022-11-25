using Blog.Application;
using Blog.Shared.Models;
using Blog.Shared.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class CommentsController : ControllerBase
{
    private readonly ICommentLogic commentLogic;

    public CommentsController(ICommentLogic commentLogic)
    {
        this.commentLogic = commentLogic;
    }

    [HttpPost]
    public async Task<ActionResult<Comment>> CreateAsync([FromBody] CommentCreationDto dto)
    {
        try
        {
            Comment created = await commentLogic.CreateAsync(dto);
            return Created($"/comments/{created.Post.Title}/{created.Id}", created);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    [HttpGet("{url}")]
    public  Task<ActionResult<List<Comment>>> GetAllCommentsByPostUrlAsync(string url)
    {
        try
        {
            var comments =  commentLogic.GetAllCommentsByPostUrlAsync(url);
            return Task.FromResult<ActionResult<List<Comment>>>(Ok(comments));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Task.FromResult<ActionResult<List<Comment>>>(StatusCode(500, e.Message));
        }
    }
}