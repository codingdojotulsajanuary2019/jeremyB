import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Tasks';
  tasks = [];
  oneTask = {};
  newTask: any;
  newInfo: any;
  delTask: any;
  
  constructor(private _service : HttpService) { 
  }
  ngOnInit() { 
    this.newTask = { title: "", description: "" }
    this.newInfo = {title: "", description: ""}
  }
  getTasks() {
    let observ = this._service.getTasks();
    observ.subscribe(data => {
      console.log("Got tasks", data);
      this.tasks = data['tasks'];
    });
  }
  getOneTask(info: String) {
    console.log("Get One Task");
    console.log(info);

    let observ = this._service.getOneTask(info);
    observ.subscribe(data => {
      console.log(data);
      this.oneTask = data['task'];
      this.newInfo = data['task'];
      console.log(this.oneTask);
    });
  }
  
  addTask(newTask: any) {
    console.log("Submitted new task");
    console.log(newTask);
    let observ = this._service.addTask({newtask: newTask});
    console.log("Trying to subscribe");
    observ.subscribe(data => console.log("Return shit", data));
    this.newTask = { title: "", description: ""}
  }
  deleteTask(delTask: String){
    console.log("delete component");
    console.log(delTask);
    let observ = this._service.deleteTask({delId: delTask});
    observ.subscribe(data => console.log("Deletd Info", data));
  }
}
