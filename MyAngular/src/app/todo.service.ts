import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from "@angular/common/http";
import { Observable } from 'rxjs';
import { TodoItem } from './shared/models/todo-item';
import { environment } from "../environments/environment";




@Injectable({
  providedIn: 'root'
})
export class TodoService {
  todoUrl = environment.apiHost + '/todo'
  constructor(private http: HttpClient) { }

  getTodo(){
    return this.http.get(this.todoUrl);
  }

  getTodoResponse() : Observable<HttpResponse<TodoItem[]>>{
    return this.http.get<TodoItem[]>(
      this.todoUrl, {observe: 'response'});
    
  }
}
