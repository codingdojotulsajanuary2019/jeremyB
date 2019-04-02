var tigger = {
    character: "Tigger",
    greet: function(){
        console.log("I am a tigger!")
    }
}
var piglet = {
    character: "Piglet",
    greet: function(){
        console.log("I'm a scaredy cat. Except a pig.")
    }
}
var winnie = {
    character: "Winnie the Pooh",
    greet: function(){
        console.log("Gimme dat honey.")
    }
}
var bees = {
    character: "Bees",
    greet: function(){
        console.log("Bzzzzzzzzzzzzzzzzzzzzzzz")
    }
}
var owl = {
    character: "Owl",
    greet: function(){
        console.log("How many licks to the center of a tootsie pop?")
    }
}
var chris = {
    character: "Christopher Robin",
    greet: function(){
        console.log("I'm a lil bitchboy.")
    }
}
var rabbit = {
    character: "Rabbit",
    greet: function(){
        console.log("Hop hop motherfucker.")
    }
}
var gopher = {
    character: "Gopher",
    greet: function(){
        console.log("I'll dig you, if you catch my drift.")
    }
}
var kanga = {
    character: "Kanga",
    greet: function(){
        console.log("My child is an asshole.")
    }
}
var eeyore = {
    character: "Eeyore",
    greet: function(){
        console.log("I'm gonna off myself.")
    }
}
var heffalumps = {
    character: "Heffalumps",
    greet: function(){
        console.log("What is a heffalump?")
    }
}

tigger.north = winnie;
winnie.south = tigger;
piglet.east = winnie;
winnie.west = piglet;
chris.south = winnie;
winnie.north = chris;
bees.west = winnie;
winnie.east = bees;
piglet.north = owl;
owl.south = piglet;
bees.north = rabbit;
rabbit.south = bees;
owl.east = chris;
chris.west = owl;
rabbit.east = gopher;
gopher.west = rabbit;
chris.east = rabbit;
rabbit.west = chris;
chris.north = kanga;
kanga.south = chris;
kanga.north = eeyore;
eeyore.south = kanga;
eeyore.east = heffalumps;
heffalumps.west = eeyore;

var locale = [tigger, winnie, piglet, chris, owl, rabbit, gopher, kanga, eeyore, heffalumps]

var player = {
    location: tigger,
    honey: false,
}

function move(str){
    if(player.location[str]){
        player.location = player.location[str];
        name = player.location.character;
        console.log(`You are now at ${name}'s house!`)
        player.location.greet();
    }
    else{
        console.log("You may not go that way!");
    }
}
function pickUp(){
    if(player.location != bees){
        console.log("No honey here");
    }
    else{
        player.honey = true;
        console.log("You gathered some honey!")
    }
}
function mission(){
    num = Math.floor((Math.random() * (11) + 0));
    obj = locale[num];
    console.log(obj.character," is looking for honey! Can you help?");
}
function drop(){
    if(player.location == obj){
        player.honey = false;
        console.log("You succesfully delivered the honey! You win!!!!")
    }
    else{
        console.log("You tried to deliver the honey to the wrong person you buffoon!")
    }
}