import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  info : object;
  ability: object;

  constructor(private _http: HttpClient) {
    this.getPokemon()
  };
  getPokemon(){
    let bulby = this._http.get('https://pokeapi.co/api/v2/pokemon/1');
    bulby.subscribe(data => {this.info = data, this.printName(), this.abilityInfo()});
  }
  //I'm so sorry to anyone who reads this code.
  printName(){
    let string: string = ""
    string += this.info.name;
    string += "'s abilities are ";
    for(let x in this.info.abilities){
      string+=this.info.abilities[x].ability.name;
      string+=", "
    }
    console.log(string);
  }
  abilityInfo(){
    for(let x in this.info.abilities){
      let thing = this._http.get(this.info.abilities[x].ability.url);
      thing.subscribe(data =>{this.ability = data, this.printAbility()});
    }
  }
  printAbility(){
    let string: string = ""
    string += this.ability.pokemon.length;
    string += " pokemon know the ability ";
    string += this.ability.name;
    string += ".";
    console.log(string);
  }
}
