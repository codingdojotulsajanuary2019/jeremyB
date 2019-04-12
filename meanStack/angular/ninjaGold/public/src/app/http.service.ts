import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) {
  };

  create() {
    console.log("create on service");
    return this._http.get('/ninja');
  }
  
  load(req) {
    console.log("load on service");
    return this._http.get(`/${req.ninja._id}`);
  }
  addGold(req) {
    console.log("addGold on service");
    console.log(req);
    return this._http.put(`/${req.id}/updateGold`, req);
  }

}
