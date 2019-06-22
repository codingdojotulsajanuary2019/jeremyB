import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';
import { ActivatedRoute, Params, Router } from '@angular/router';

@Component({
  selector: 'app-review',
  templateUrl: './review.component.html',
  styleUrls: ['./review.component.css']
})
export class ReviewComponent implements OnInit {

  constructor(
    private _service:HttpService,
    private _route: ActivatedRoute,
    private _router: Router
    ) { }

  id: any;
  movie: any;
  info: any;

  ngOnInit() {
    this._route.params.subscribe((params:Params)=> {
      this.id = params['id'];
    })
    this.getMovie(this.id);
    this.info = {
      name: "",
      comment: "",
      stars: 0
    }
  }

  getMovie(id){
    console.log("Get one")
    let movie = this._service.getOne(id);
    movie.subscribe(data => {
      console.log(data);
      this.movie = data;
    })
  }

  newReview(info:any){
    console.log("new review");
    console.log(info);
    let review = this._service.review(this.id, info);
    review.subscribe(data => {
      console.log("review added", data)
    })
    this._router.navigate(['/']);
  }
}
