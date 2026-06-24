import { Component, signal } from '@angular/core';
import { TodoType } from '../../types';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-todo',
  imports: [FormsModule],
  templateUrl: './todo.html',
  styleUrl: './todo.css',
})

export class Todo {
  loading = signal(true);
  todo = signal({ id: -100, title: "", tasks: [] } as TodoType);
  taskTitle = "";

  ngOnInit() {
    fetch("http://localhost:5117/api/todos/todo")
      .then(res => res.json())
      .then(res => {
        this.todo.set(res);
        this.loading.set(false);
      });
  }

  addTask() {
    console.log(this.taskTitle);
    fetch("http://localhost:5117/api/todos/todo", {
      method: "post",
      body: JSON.stringify({ title: this.taskTitle }),
      headers: {"Content-Type": "application/json"},
      credentials: "include"
    })
      .then(res => res.json())
      .then(res => {
        this.todo.set(res); 
      });
  }
}
