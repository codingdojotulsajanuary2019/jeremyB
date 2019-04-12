var Quote = require('../models/quote.js');

module.exports = {
    index: function(req, res) {
        console.log("index page");
        res.render('index');   
    },

    new: function(req, res) {
        console.log("POST DATA", req.body);
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
    },

    quotes: function(req, res) {
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
    }
}