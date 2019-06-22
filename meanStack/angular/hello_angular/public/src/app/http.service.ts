import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) { }

  getTasks(){
    console.log("get Tasks on Service");
    return this._http.get('/tasks');
  }
  getOneTask(title: String){
    console.log("get 1 task on Service");
    console.log(title);
    return this._http.get(`/${title}`);
  }
  addTask(newtask){
    console.log("Add task on service");
    console.log(newtask);
    return this._http.post('/tasks', newtask);
  }
  editTask(newinfo){
    console.log("Edit task on service");
    console.log(newinfo.newinfo);
    console.log(newinfo.newinfo.title);
    return this._http.put(`/${newinfo.newinfo.title}`, newinfo);
  }
  deleteTask(delInfo){
    console.log("Delete task on service");
    console.log(delInfo);
    return this._http.delete(`/${delInfo.delId}`, delInfo);

  }
}
