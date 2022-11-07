using Blog.Application;
using Blog.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Blog.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly RegistrInterface registrationLogic;

    public UserController(RegistrInterface registrationLogic)
    {
        this.registrationLogic = registrationLogic;
    }

    [HttpPost]
    public async Task<ActionResult<UserDto>> CreateAsync([FromBody] UserDto dto)
    {
        try
        {
            UserDto createdDto = await registrationLogic.CreateAsync(dto);
            return Created($"{$"/register/{createdDto.Id}"}", createdDto);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}
