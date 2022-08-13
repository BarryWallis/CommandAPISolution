using CommandAPI.Data;
using CommandAPI.Models;

using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommandsController : ControllerBase
{
    private readonly ICommandAPIRepo _repository;

    public CommandsController(ICommandAPIRepo repository) => _repository = repository;

    [HttpGet]
    public ActionResult<IEnumerable<string>> GetAllCommands()
    {
        IEnumerable<Command> commandItems = _repository.GetAllCommands();
        return Ok(commandItems);
    }

    [HttpGet("{id}")]
    public ActionResult<Command> GetCommmandById(int id)
    {
        Command? commandItem = _repository.GetCommandById(id);
        return commandItem is null ? NotFound() : Ok(commandItem);
    }
}
