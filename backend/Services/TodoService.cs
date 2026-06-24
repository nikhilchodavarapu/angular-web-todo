using backend.Models;

namespace backend.Services;

public class TodoService
{
  Todo todo = new();
  public TodoService()
  {
    todo.Id = 1;
    todo.Title = "My Todo";

    Models.Task task = new();
    task.Id = todo.NextId++;
    task.Title = "Task - 1";
    task.IsCompleted = true;

    todo.Tasks = [task];
  }

  public Todo GetTodo()
  {
    return todo;
  }

  public void AddTodo(string title)
  {
    Console.WriteLine(title);
    Models.Task task = new();
    task.Id = todo.NextId++;
    task.Title = title;
    task.IsCompleted = false;

    Console.WriteLine(todo.Tasks.ToArray().Length);
    todo.Tasks.Add(task);
  }
}