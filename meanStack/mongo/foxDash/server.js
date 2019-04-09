// Require the Express Module
var express = require('express');
// Create an Express App
var app = express();
// Require body-parser (to receive post data from clients)copy
var bodyParser = require('body-parser');
// Integrate body-parser with our App
app.use(bodyParser.urlencoded({ extended: true }));
// Require path
var path = require('path');
// Setting our Static Folder Directory
app.use(express.static(path.join(__dirname, './static')));

const flash = require('express-flash');

var mongoose = require('mongoose');
mongoose.connect('mongodb://localhost/basic_mongoose');
var FoxSchema = new mongoose.Schema({
    name: {type: String, required: true, minlength:2},
    age: {type: Number, min:1, max: 20},
    food: {type: String, required: true, minlength:4}
   }, {timestamps: true});
   mongoose.model('Fox', FoxSchema); // We are setting this Schema in our Models as 'User'
   var Fox = mongoose.model('Fox') // We are retrieving this Schema from our Models, named 'User'
// Setting our Views Folder Directory
app.set('views', path.join(__dirname, './views'));
// Setting our View Engine set to EJS
app.set('view engine', 'ejs');
// Routes
// Root Request
app.get('/', function(req, res) {
    console.log("index page");
    Fox.find({}, function(err, foxes) {
        if(err){
            console.log(err);
        } else {
            res.render('index', {foxes: foxes});
        }
    })
})
//Display new fox form
app.get('/foxes/new', function(req, res) {
    console.log("Got to new display page");
    res.render('new');
})
//Add new fox route
app.post('/foxes', function(req, res) {
    console.log("POST DATA", req.body);
    var fox = new Fox(req.body);
    console.log(fox);
    fox.save(function(err) {
        if(err) {
            console.log("Something went wrong");
            console.log(fox.errors);
            res.render('new', {errors: fox.errors})
        }
        else {
            console.log("Successfully added a fox!");
            res.redirect('/');
        }
    })
})
//Singular fox display
app.get('/foxes/:id', function(req, res){
    console.log("info page");
    console.log(req.params.id);
    Fox.findOne({_id:req.params.id}, function(err, fox) {
        if(err) {
            return console.log(err);
        }
        else {
            console.log(fox);
            res.render('info', {fox});
        }
    })
})
//Edit fox display
app.get('/foxes/edit/:id', function(req, res) {
    console.log("edit page");
    console.log(req.params.id);
    Fox.findOne({_id:req.params.id}, function(err, fox) {
        if(err) {
            console.log(err);
        }
        else {
            console.log(fox);
            res.render('edit', {fox});
        }
    })
})
//Update fox information
app.post('/foxes/:id', function(req, res) {
    console.log("update route");
    console.log("POST DATA", req.body);
    Fox.update({_id:req.params.id},
        { name: req.body.name,
        age: req.body.age,
        food: req.body.food},
        function(err) {
            if(err) {
                console.log("error");
                console.log(err);
                res.redirect(`foxes/edit/${req.params.id}`)
            }
            else {
                console.log("Successfully updated a fox!");
                res.redirect(`/foxes/${req.params.id}`);
            }
        })
})
//Delete a fox
app.post('/foxes/destroy/:id', function(req, res) {
    console.log("Delete route")
    Fox.deleteOne({_id:req.params.id}, function(err) {
        if(err){
            console.log(err);
            res.redirect('/');
        }
        else{
            console.log("Record deleted")
            res.redirect('/');
        }
    })
})

// Setting our Server to Listen on Port: 8000
app.listen(8000, function() {
  console.log("listening on port 8000");
});