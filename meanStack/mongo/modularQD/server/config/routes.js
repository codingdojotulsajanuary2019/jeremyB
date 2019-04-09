const mongoose = require('mongoose'),
    Quote = mongoose.model('Quote')
module.exports = function(app){
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
}