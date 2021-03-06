import { Component, OnInit } from '@angular/core';
import {HttpService} from '../http.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  authors:any = [];
  constructor(private _service:HttpService) { }
  
  ngOnInit() {
    this.getAuthors();
  }
  
  getAuthors() {
    let observ = this._service.getAll();
    observ.subscribe(data => {
      console.log("Got authors", data);
      this.authors = data;
    })
  }
}
