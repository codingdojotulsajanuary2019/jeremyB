import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Ninja Gold';
  id = "";
  total = 0;
  log = []

  constructor(private _service: HttpService) {
  }
  ngOnInit() {
    console.log("Welcome to Ninja Gold");
    let stuff;
    let info;
    info = this._service.create();
    info.subscribe(data =>{
      stuff = data,
      console.log(stuff),
      this.id = stuff.ninja._id;
      console.log(stuff.ninja._id),
      this._service.load(stuff).subscribe(data2 => console.log(data2)) });
  }

  findGold(location) {
    let gold = 0;
    let string: string;
    console.log(location);
    string = ""
    if (location == 'farm') {
      gold = Math.floor(Math.random() * 11 + 10)
      string += `You found ${gold} gold at the farm.`
    }
    else if (location == 'caves') {
      gold = Math.floor(Math.random() * 6 + 5)
      string += `You found ${gold} gold at the cave.`
    }
    else if (location == 'house') {
      gold = Math.floor(Math.random() * 3 + 2)
      string += `You found ${gold} gold at the house.`
    }
    else if (location == 'casino') {
      gold = (Math.floor(Math.random() * 101))-50;
      string += `You left the casino with ${gold} gold.`
    }
    this.total += gold;
    this.log.push(string)
    let observable = this._service.addGold({id: this.id, gold: gold, action : string}).subscribe(data => {
      console.log("Ninja updated!", data);
    });
  }
}
