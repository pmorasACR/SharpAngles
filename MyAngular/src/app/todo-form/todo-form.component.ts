import { Component, OnInit } from '@angular/core';
import { TodoItem } from "../shared/models/todo-item";
import { TodoService } from '../todo.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-todo-form',
  templateUrl: './todo-form.component.html',
  styleUrls: ['./todo-form.component.css']
})
export class TodoFormComponent implements OnInit {
  model = new TodoItem('');
  
  constructor(private todoService : TodoService, private router : Router) { }
  ngOnInit() {
  }

  submitted = false;

  onSubmit() { 
    this.submitted = true;
    let promise =  this.todoService.addTodo(this.model);
    promise.subscribe(todo => this.router.navigateByUrl('/'));
    
  }

  newTodo(){
    this.model = new TodoItem('new');
  }
  // TODO: Remove this when we're done
  get diagnostic() { return JSON.stringify(this.model); }
}
