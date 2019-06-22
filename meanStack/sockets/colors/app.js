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

var color;
io.on('connection', function(socket) {
    socket.emit('background', {color: 'yellow'});
    socket.on('color',function(data) {
        data.color;
        io.emit('background', {color: data.color})
    })
});


app.get('/', function(req, res) {
    res.render("index");
})