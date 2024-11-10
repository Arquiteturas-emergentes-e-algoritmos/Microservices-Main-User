using Microsoft.AspNetCore.Mvc;
using User.Application.Commands;
using User.Application.Services;

namespace User.WebApi.Controllers;

[Controller]
[Route("v1/user")]
public class UserController : ControllerBase
{

    [HttpPost]
    [Route("")]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(object), StatusCodes.Status500InternalServerError)]
    public IActionResult CreateUser([FromBody] CreateUserCommand command, [FromServices] UserService handler)
    {
        try
        {
            if (!ModelState.IsValid || !command.Validate())
                return BadRequest();

            handler.Handle(command);

            return Ok("Adicionado com sucesso");
        }

        catch (Exception ex)
        {
            return StatusCode(500, ex);
        }
    }

    [HttpGet]
    [Route("")]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(object), StatusCodes.Status500InternalServerError)]
    public IActionResult CreateUser([FromBody] GetUserCommand command, [FromServices] UserService handler)
    {
        try
        {
            if (!ModelState.IsValid || !command.Validate())
                return BadRequest();

            return Ok(handler.Handle(command));
        }

        catch (Exception ex)
        {
            return StatusCode(500, ex);
        }
    }
}
