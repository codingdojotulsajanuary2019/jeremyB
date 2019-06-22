import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { HttpService } from '../../http.service';

@Component({
  selector: 'app-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.css']
})
export class NewComponent implements OnInit {

  constructor(private _service:HttpService) { }
  errors = {};
  newmovie:any;
  @Output() reload = new EventEmitter();

  ngOnInit() {
    this.newmovie = {
      title: "",
      review: [ {
        name: "",
        comment: "",
        stars: 0
      }]
    }
  }

  newMovie(newmovie) {
    console.log(newmovie);
    let observ = this._service.addMovie(newmovie);
    observ.subscribe(data => {
      console.log(data);
      if(data['success']==false){
        this.errors['message'] = data['error']['errors'].message;
      }
      this.reload.emit();
    })
  }
}
