using backend.DTO;
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


  [HttpPost]
  [Route("todo")]
  public IActionResult AddTask(CreateTaskDto dto)
  {
    Console.WriteLine("Add Task");
    todoService.AddTodo(dto.Title);
    return Ok(todoService.GetTodo());
  }
}