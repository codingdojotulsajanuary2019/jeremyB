console.log("________1________")
// Given
// console.log(hello);                                   
// var hello = 'world';                                 
// after interpretation
var hello;
console.log(hello);//logs undefined
hello = 'world';


console.log("________2________")
var needle = 'haystack';
test();
function test(){
	var needle = 'magnet'; // Var would be interpreted on start of page
	console.log(needle); //logs magnet
}

console.log("________3________")
var brendan = 'super cool';
function print(){
	brendan = 'only okay';
	console.log(brendan); //never called
}
console.log(brendan); //super cool

console.log("________4________")
var food = 'chicken';
console.log(food); //chicken
eat();
function eat(){
	food = 'half-chicken';
	console.log(food); //half-chicken
	var food = 'gone';//var would not be interpreted here
}

console.log("________5________")
// Error: Mean is not a function
//Given:
// mean();
// console.log(food);
// var mean = function() {
// 	food = "chicken";
// 	console.log(food);
// 	var food = "fish";
// 	console.log(food);
// }
// console.log(food);
// Interpreted:
// var mean
// mean();
// mean=function(){
//     etc
// }

console.log("________6________")
console.log(genre);//undefined
var genre = "disco";
rewind();
function rewind() {
	genre = "rock";
	console.log(genre);//rock
	var genre = "r&b";
	console.log(genre);//r&b
}
console.log(genre);//disco

console.log("________7________")
dojo = "san jose";
console.log(dojo); //san jose
learn();
function learn() {
	dojo = "seattle";
	console.log(dojo);//seattle
	var dojo = "burbank";
	console.log(dojo);//burbank
}
console.log(dojo);//san jose

console.log("________8________")
console.log(makeDojo("Chicago", 65));
console.log(makeDojo("Berkeley", 0));
function makeDojo(name, students){
        const dojo = {};
        dojo.name = name;
        dojo.students = students;
        if(dojo.students > 50){
            dojo.hiring = true;
        }
        else if(dojo.students <= 0){
            dojo = "closed for now";
        }
        return dojo;
}
//Log:
//{ name: 'Chicago', students: 65, hiring: true }
//Error dojo = "closed" to constant variable