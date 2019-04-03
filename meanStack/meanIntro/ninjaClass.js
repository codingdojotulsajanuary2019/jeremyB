function Ninja(name){
    var self = this;
    this.name = name;
    this.health = 100;
    var speed = 3;
    var strength = 3;

    this.sayName = function(){
        console.log("My name is ",this.name);
    }
    this.showStats = function(){
        console.log("Name: "+this.name + ", Health: "+this.health+", Speed: "+speed+", Strength: "+strength);
    }
    this.drinkSake = function(){
        this.health += 10;
        console.log(this.name+"'s new health is: "+this.health);
    }
//Ninja Class 2
    this.punch = function(targ){
        if(targ instanceof Ninja){
            dmg = 5*strength;
            targ.health -= dmg;
            console.log(targ.name+" was punched by "+this.name+" and lost "+dmg+" health!")
        }
        else{
            console.log("One must only punch a ninja.")
        }
    }
    this.kick = function(targ){
        if(targ instanceof Ninja){
            dmg = 15*strength;
            targ.health -= dmg;
            console.log(targ.name+" was kicked by "+this.name+" and lost "+dmg+" health!")
        }
        else{
            console.log("One must only kick a ninja.")
        }
    }
}