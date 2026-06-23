using backend.Services;
using Microsoft.AspNetCore.Mvc;
namespace backend.Controllers;

[ApiController]
[Route("api/todos")]
public class TodoController : ControllerBase
{
  TodoService todoService = new();

  [HttpGet]
  public IActionResult GetAll()
  {
    return Ok();
  }

  [HttpGet]
  [Route("todo")]
  public IActionResult GetTodo()
  {
    return Ok(todoService.GetTodo());
  }
}