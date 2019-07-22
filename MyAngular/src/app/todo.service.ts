import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse, HttpHeaders, HttpErrorResponse } from "@angular/common/http";
import { Observable, throwError } from 'rxjs';
import { catchError,map } from "rxjs/operators";
import { TodoItem } from './shared/models/todo-item';
import { environment } from "../environments/environment";

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    'Authorization': 'my-auth-token',
    'Access-Control-Allow-Origin': '*'
  })
};


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

  addTodo(todo:TodoItem) : Observable<TodoItem>{
    return this.http.post<TodoItem>(this.todoUrl,JSON.stringify(todo), httpOptions).pipe(
      catchError(e=> this.handleError(e))
    );
  }
 
  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.error.message);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      console.error(
        `Backend returned code ${error.status}, ` +
        `body was: ${error.error}`);
    }
    // return an observable with a user-facing error message
    return throwError(
      'Something bad happened; please try again later.');
  };
}
