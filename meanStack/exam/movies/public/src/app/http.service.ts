import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) { }

  getAll(){
    console.log("All on service");
    return this._http.get('/movies');
  }

  addMovie(movie) {
    console.log("new on service");
    return this._http.post('/movies/new', movie);
  }

  getOne(id) {
    console.log("one on service");
    return this._http.get(`/movies/${id}`);
  }

  review(id, info){
    console.log("review on service");
    return this._http.put(`/movies/${id}/review`, info);
  }

  deleteMovie(id){
    console.log("delete movie on service");
    console.log(id);
    return this._http.delete(`/movies/delete/${id}`);
  }

  deleteReview(id, rev){
    console.log("Delete review on service")
    return this._http.put(`/movies/delete/${id}/${rev}`, "");
  }
}
