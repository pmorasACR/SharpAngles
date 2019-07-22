import { Component, OnInit, Injectable } from '@angular/core';
import { TodoService } from '../todo.service';
import { Observable } from 'rxjs';
import { TodoItem } from '../shared/models/todo-item';
import { HttpResponse } from '@angular/common/http';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css']
})

export class TodoComponent implements OnInit {
  data : TodoItem[];
  headers: string[];
  constructor(private todoService : TodoService) { }

  ngOnInit() {
    console.log("init todo");
    this.showTodoResponse();
  }

  // showTodo(){
  //   this.configService.getTodo().subscribe( data => this.data = data);
  // }

  showTodoResponse(){
    this.todoService.getTodoResponse()
      .subscribe(resp => {
        const keys = resp.headers.keys();
        //get the header data and format it
        this.headers = keys.map(key =>
          `${key}: ${resp.headers.get(key)}`
          );
        //get the body data, too
        this.data = resp.body

      });
  }
  
  
}
