import { Component, OnInit } from '@angular/core';
import { TodoItem } from "../shared/models/todo-item";

@Component({
  selector: 'app-todo-form',
  templateUrl: './todo-form.component.html',
  styleUrls: ['./todo-form.component.css']
})
export class TodoFormComponent implements OnInit {
  model = new TodoItem('');
  
  constructor() { }
  ngOnInit() {
  }

  submitted = false;

  onSubmit() { this.submitted = true }

  newTodo(){
    this.model = new TodoItem('new');
  }
  // TODO: Remove this when we're done
  get diagnostic() { return JSON.stringify(this.model); }
}
