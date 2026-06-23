using backend.Models;

namespace backend.Services;

public class TodoService
{
  Todo todo = new();
  public TodoService()
  {
    todo.Id = 1;
    todo.Title = "My Todo";
    todo.IsCompleted = true;
  }

  public Todo GetTodo()
  {
    return todo;
  }
}