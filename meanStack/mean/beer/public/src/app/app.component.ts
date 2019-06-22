import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'public';
  beer: any;
  beers = [];
  beerClicked: any;

  constructor(private _http: HttpService){}

  ngOnInit(){
    this.beer={brewer:"",img:""}
    this.getBeers();
  }
  newBeer(beer:any){
    console.log("New beer in component");
    console.log(beer);
    console.log(this.beer);
    let observ = this._http.newBeer(beer);
    observ.subscribe(data => {
      console.log(data);
    });
    this.getBeers();
  }
  getBeers(){
    let observ = this._http.getBeers();
    observ.subscribe(data => {
      console.log("Got beers", data);
      this.beers = data['beers'];
    });
  }
  showBeer(beer){
    this.getBeers();
    this.beerClicked = beer;
    console.log(beer);
  }
}
