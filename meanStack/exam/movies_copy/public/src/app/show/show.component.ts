import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';
import { ActivatedRoute, Params, Router } from '@angular/router';

@Component({
  selector: 'app-show',
  templateUrl: './show.component.html',
  styleUrls: ['./show.component.css']
})
export class ShowComponent implements OnInit {

  constructor(
    private _service:HttpService,
    private _route: ActivatedRoute,
    private _router: Router
  ) { }

  id:any;
  movie:any;

  ngOnInit() {
    this._route.params.subscribe((params:Params)=> {
      this.id = params['id'];
    })
    this.getMovie(this.id);
  }

  getMovie(id){
    console.log("Get one")
    let movie = this._service.getOne(id);
    movie.subscribe(data => {
      console.log(data);
      this.movie = data;
    })
  }

  deleteMovie(id){
    console.log(id);
    let observ = this._service.deleteMovie(id);
      observ.subscribe(data => {
        console.log("deleted");
        console.log(data);
      })
      this._router.navigate(['/']);
  }

  delRev(rev){
    console.log(this.id);
    console.log(rev);
    let observ = this._service.deleteReview(this.id, rev);
    observ.subscribe(data => {
      console.log("deleted review");
      console.log(data);
    })
    this.getMovie(this.id);
  }

}
