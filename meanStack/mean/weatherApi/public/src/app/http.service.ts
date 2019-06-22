import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) { }

  getWeather(city){
    console.log("Service call");
    console.log(city);
    return this._http.get(`http://api.openweathermap.org/data/2.5/weather?q=${city}&units=imperial&APPID=2349f6fce10c6ed252bda0b7d8ddda2c`)
  }
}
