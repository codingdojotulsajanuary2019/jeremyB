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

// tell the express app to listen on port 8000
const server = app.listen(8000);
const io = require('socket.io')(server);

io.on('connection', function(socket){
    socket.on('survey', function(data){
        console.log("-".repeat(10));
        console.log(data);
        let lucky = Math.floor(Math.random()*1000);
        socket.emit('msg', {
            msg: `you emitted the following information to the server: {Name: '${data.name}', Location: '${data.location}', Language: '${data.language}', Comment: '${data.comment}'}`,
            lucky: `Your lucky number emitted by the server is ${lucky}`
        })
    })
});

//ROUTES/////////////////////////////////////////////
// root route to render the index.ejs view
app.get('/', function(req, res) {
    res.render("index");
})
