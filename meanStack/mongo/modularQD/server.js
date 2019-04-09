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
var QuoteSchema = new mongoose.Schema({
    name: {type: String, required: true, minlength:6 },
    quote: {type: String, required: true, minlength: 18} 
   }, {timestamps: true});
   mongoose.model('Quote', QuoteSchema); // We are setting this Schema in our Models as 'User'
   var Quote = mongoose.model('Quote') // We are retrieving this Schema from our Models, named 'User'
// Setting our Views Folder Directory
app.set('views', path.join(__dirname, './views'));
// Setting our View Engine set to EJS
app.set('view engine', 'ejs');
// Routes
// Root Request
app.get('/', function(req, res) {
    // This is where we will retrieve the users from the database and include them in the view page we will be rendering.
    console.log("index page");
    res.render('index');
})
// Add User Request 
app.post('/quotes', function(req, res) {
    console.log("POST DATA", req.body);
    // create a new User with the name and age corresponding to those from req.body
    var quote = new Quote({name: req.body.name, quote: req.body.quote});
    console.log(quote);
    quote.save(function(err) {
        if(err){
            console.log("Something went wrong");
            console.log(quote.errors);
            res.render('index', {errors: quote.errors})
        }
        else {
            console.log('Succesfully added a quote!');
            res.redirect('/quotes');
        }
    })
})

app.get('/quotes', function(req, res){
    console.log("Got to quotes page");
    Quote.find({})
        .sort('-createdAt')
        .exec(function(err, quotes) {
            if (err) {
                console.log("Something went wrong");
            }
            else {
                console.log(quotes);
                res.render('quotes', {quotes});
            }
        })
})

// Setting our Server to Listen on Port: 8000
app.listen(8000, function() {
    console.log("listening on port 8000");
});