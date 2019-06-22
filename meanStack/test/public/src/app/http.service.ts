import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) { }

  getAll(){
    console.log("All on Service");
    return this._http.get('/authors');
  }

  addAuthors(author) {
    console.log("new on service");
    return this._http.post('/authors/new', author);
  }
}
