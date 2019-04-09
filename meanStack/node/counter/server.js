// require express
var express = require("express");
// path module -- try to figure out where and why we use this
var path = require("path");
// create the express app
var app = express();
var session = require("express-session");
app.use(session({
    secret:"potato",
    resave: false,
    saveUninitialized: true,
    cookie: {maxAge: 60000}
}))
var bodyParser = require('body-parser');
// use it!
app.use(bodyParser.urlencoded({ extended: true }));
// static content
app.use(express.static(path.join(__dirname, "./static")));
// setting up ejs and our views folder
app.set('views', path.join(__dirname, './views'));
app.set('view engine', 'ejs');

//ROUTES/////////////////////////////////////////////
// root route to render the index.ejs view
app.get('/', function(req, res) {
    if(req.session.count == undefined)
    {
        console.log("got here");
        req.session.count = 1;
        res.locals.count = req.session.count;
    }
    else
    {
        req.session.count ++;
        res.locals.count = req.session.count;
    }
    console.log(req.session);
    res.render("index");
})
app.get('/addtwo', function(req, res) {
    req.session.count +=1;
    res.redirect('/')
})
app.get('/reset', function(req, res) {
    req.session.destroy();
    res.redirect('/')
})

// tell the express app to listen on port 8000
app.listen(8000, function() {
 console.log("listening on port 8000");
});
