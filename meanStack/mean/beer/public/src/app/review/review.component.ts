import { Component, OnInit, Input } from '@angular/core';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-review',
  templateUrl: './review.component.html',
  styleUrls: ['./review.component.css']
})
export class ReviewComponent implements OnInit {

  constructor(private _http : HttpService) { }
  @Input() beer: any;
  info: any;

  ngOnInit() {
    console.log("Reading the review app");
    console.log(this.beer);
    this.info = {comment: "", rate: ""}
  }
  newReview(info:any){
    console.log("New review in component");
    console.log(info);
    console.log(this.beer);
    let observ = this._http.review(this.beer._id, info);
    observ.subscribe(data => {
      console.log("it worked", data);
    })
  }

}
