import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) { }

  getAll(){
    console.log("Get all on Service");
    return this._http.get('authors');
  }
  addAuthor(author) {
    console.log("Add author on service");
    console.log(author);
    return this._http.post('add', author.newauthor);
  }
}
