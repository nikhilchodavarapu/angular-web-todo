import { Component } from '@angular/core';

@Component({
  selector: 'app-todo',
  imports: [],
  templateUrl: './todo.html',
  styleUrl: './todo.css',
})

export class Todo {
  todo = {
    id: 1,
    title: "My Todo",
    tasks: [
      { id: 1, title: "Task - 1", isCompleted: true },
      { id: 2, title: "Task - 2", isCompleted: false }
    ]
  }
}
