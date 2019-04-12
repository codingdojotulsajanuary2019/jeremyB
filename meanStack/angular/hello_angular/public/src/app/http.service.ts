import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  constructor(private _http: HttpClient) {
    this.getTasks();
    this.getOneTask();
  }
  getTasks(){
    console.log("Get Tasks Route");
    let allTasks = this._http.get('/tasks');
    allTasks.subscribe(data => console.log("Tasks:", data));
  }
  getOneTask(){
    console.log("Get One Task");
    let oneTask = this._http.get('/Test');
    oneTask.subscribe(data => console.log("A task:", data));
  }
}
