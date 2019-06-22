import { Component, OnInit, Input } from '@angular/core';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-single',
  templateUrl: './single.component.html',
  styleUrls: ['./single.component.css']
})
export class SingleComponent implements OnInit {
  oneTask = {};
  newInfo: any;
  @Input() taskToShow: any;

  constructor(private _service : HttpService) { 
  }

  ngOnInit() {
    console.log("reading single component");
    this.newInfo = {title: "", description: ""}
  }

  editTask(newInfo: any) {
    console.log("Edit task info");
    console.log(newInfo);
    console.log(this.taskToShow);
    let observ = this._service.editTask({newinfo: newInfo});
    observ.subscribe(data => console.log("Edited info", data));
    this.newInfo = {title: "", description: ""}
  }
}
