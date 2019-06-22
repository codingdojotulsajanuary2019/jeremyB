import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-burbank',
  templateUrl: './burbank.component.html',
  styleUrls: ['./burbank.component.css']
})
export class BurbankComponent implements OnInit {

  constructor(private _service: HttpService) { }
  city="burbank";
  info: any;
  ngOnInit() {
    this.getWeather(this.city);
  }
  getWeather(city){
    console.log("Call happening");
    let observ = this._service.getWeather(city);
    observ.subscribe(data => {
      console.log("Got weather for:", data);
      this.info = data;
      console.log(this.info);
    })
    console.log("info:",this.info);
  }
}
