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

require('./server/config/routes.js')(app)
// Setting our Server to Listen on Port: 8000
app.listen(8000, function() {
    console.log("listening on port 8000");
});