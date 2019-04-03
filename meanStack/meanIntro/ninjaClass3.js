class Ninja{
    constructor(callsign){
        this.name = callsign;
        this.health = 100;
        this.strength = 3;
        this.speed = 3;
    }
    sayName() {
        console.log(`My name is ${this.name}`);
    }
    showStats() {
        console.log(`Name: ${this.name} Health: ${this.health} Strength: ${this.strength} Speed: ${this.speed}`);
    }
    drinkSake() {
        this.health += 10;
        console.log(`${this.name}'s new health is: ${this.health}.`);
    }
}

class Sensei extends Ninja {
    constructor(callsign) {
        super(callsign);
        this.health = 200;
        this.strength = 10;
        this.speed = 10;
        this.wisdom = 10;
    }
    speakWisdom() {
        super.drinkSake();
        console.log("Something wise.")
    }
}
var x = new Ninja("Potato")
var y = new Sensei("Apples")