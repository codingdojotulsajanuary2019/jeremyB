var express = require("express");
var path = require("path");
var app = express();
var bodyParser = require('body-parser');
app.use(bodyParser.urlencoded({ extended: true }));
app.use(express.static(path.join(__dirname, "./static")));
app.set('views', path.join(__dirname, './views'));
app.set('view engine', 'ejs');

const server = app.listen(8000);
const io = require('socket.io')(server);

var num = 0;
io.on('connection', function(socket) {
    console.log("connection started");
    socket.on('count', function(data) {
        console.log("Got a click");
        if(data.count == "reset") {
            num = 0;
            io.emit('user', {count:num});
        }
        else {
            num += data.count;
            console.log(num);
            io.emit('user2', {count: num});
        }
    })
    socket.on('reset', function(data) {
        console.log("Got a reset");
        if(data.count == "reset") {
            num = 0;
            io.emit('user', {count:num});
        }
        else {
            num += data.count;
            console.log(num);
            io.emit('user2', {count: num});
        }
    })
});


app.get('/', function(req, res) {
    res.render("index");
})