import { Component, OnInit } from '@angular/core';
import {HttpService} from '../http.service';

@Component({
  selector: 'app-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.css']
})
export class NewComponent implements OnInit {
  newauthor: any
  constructor(private _service:HttpService) { }

  ngOnInit() {
    this.newauthor={name: ""}
  }
  addAuthor(newauthor: any) {
    console.log(newauthor);
    let observ = this._service.addAuthor({newauthor});
    observ.subscribe(data => console.log("return shit", data));
  }
}
