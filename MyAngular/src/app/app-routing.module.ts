import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TodoComponent } from './todo/todo.component';
import { TodoFormComponent } from "./todo-form/todo-form.component";

const routes: Routes = [
  {
    path: '',
    component: TodoComponent,
  },
  {
    path:'todoform',
    component: TodoFormComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
