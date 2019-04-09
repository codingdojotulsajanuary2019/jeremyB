// Load the express module and store it in the variable express (Where do you think this comes from?)
var express = require("express");
console.log("Let's find out what express is", express);
// invoke express and store the result in the variable app
var app = express();
console.log("Let's find out what app is", app);
// use app's get method and pass it the base route '/' and a callback
app.get('/cars', function(request, response) {
       response.render('cars');
    })
app.get('/cats', function(request, response) {
    response.render('cats');
    })
app.get('/cats/boxxy', function(request, response) {
    var boxxy_data = {name: "Boxxy",
        age: 6,
        favFood: "Potatoes",
        hobbies: ["sitting in a box", "sleeping in a box"]};
    response.render('boxxy', {info: boxxy_data});
    })
app.get('/cats/joker', function(request, response) {
    var joker_data = {name: "Joker",
        age: "Unkown",
        favFood: "Jokes",
        hobbies: ["trying to kill batman","making jokes", "robbing banks"]}
    response.render('joker', {info: joker_data});
    })
app.get('/cars/new', function(request, response) {b
    response.render('form');
    })
// tell the express app to listen on port 8000, always put this at the end of your server.js file
app.listen(8000, function() {
  console.log("listening on port 8000");
})
app.use(express.static(__dirname + "/static"));

app.set('views', __dirname + '/views');
app.set('view engine', 'ejs');