import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';

@Component({
  selector: 'app-rev-det',
  templateUrl: './rev-det.component.html',
  styleUrls: ['./rev-det.component.css']
})
export class RevDetComponent implements OnInit {
  id: Number;

  constructor(
    private _route: ActivatedRoute,
    private _router: Router
  ) { }

  ngOnInit() {
    this._route.params.subscribe(params => {
      console.log(params['id']);
      this.id = params['id'];
    })
  }

}
