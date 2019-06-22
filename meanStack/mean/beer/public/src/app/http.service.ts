import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) { }

  getBeers(){
    console.log("Get beers on service");
    return this._http.get('/beers');
  }
  newBeer(beer){
    console.log("New beer on service");
    console.log(beer);
    return this._http.post('/beers', beer);
  }
  review(id, comment){
    console.log("Add review on service");
    return this._http.put(`/beers/${id}`, comment);
  }
}
