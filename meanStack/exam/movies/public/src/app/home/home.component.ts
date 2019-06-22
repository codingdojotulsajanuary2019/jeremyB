import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  movies: any = [];
  newForm = false;

  constructor(private _service:HttpService) { }

  ngOnInit() {
    this.getMovies();
  }

  getMovies() {
    let observ = this._service.getAll();
    observ.subscribe(data => {
      console.log("Got Movies", data);
      this.movies = data;
    })
  }

  addNew() {
    console.log("Clicked for new form");
    this.newForm = true;
  }

  trigger() {
    this.getMovies();
    this.newForm = false;
  }
}
