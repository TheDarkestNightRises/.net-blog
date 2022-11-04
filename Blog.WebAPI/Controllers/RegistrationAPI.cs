using Blog.Application;
using Blog.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Blog.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("register")]
public class RegistrationAPI : ControllerBase
{
    private readonly RegistrInterface registrationLogic;

    public RegistrationAPI(RegistrInterface registrationLogic)
    {
        this.registrationLogic = registrationLogic;
    }

    [HttpPost]
    public async Task<ActionResult<RegisterDto>> CreateAsync([FromBody] RegisterDto dto)
    {
        try
        {
            RegisterDto createdDto = await registrationLogic.CreateAsync(dto);
            return Created($"/register/{createdDto.Email}", createdDto);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}
