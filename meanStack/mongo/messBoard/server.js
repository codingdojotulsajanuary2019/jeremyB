var express = require('express');
var app = express();
var bodyParser = require('body-parser');
app.use(bodyParser.urlencoded({ extended: true }));
var path = require('path');
app.use(express.static(path.join(__dirname, './static')));
app.set('views', path.join(__dirname, './views'));
app.set('view engine', 'ejs');
const flash = require('express-flash');

var mongoose = require('mongoose');
mongoose.connect('mongodb://localhost/basic_mongoose');
var CommSchema = new mongoose.Schema({
    Cname: {type: String, required: [true, 'Need a name!'], minlength:[2, "Name must be more than 2 characters long"]},
    Ccontent: {type: String, required: [true, "Gotta eat something"], minlength:4},
}, {timestamps: true});
mongoose.model('Comm', CommSchema);
var Comm = mongoose.model('Comm')
    
var MessSchema = new mongoose.Schema({
    Mname: {type: String, required: [true, 'Need a name!'], minlength:[2, "Name must be more than 2 characters long"]},
    Mcontent: {type: String, required: [true, "Gotta eat something"], minlength:4},
    comments: [CommSchema]
}, {timestamps: true});
mongoose.model('Mess', MessSchema);
var Mess = mongoose.model('Mess')


app.get('/', function(req, res) {
    console.log("index page");
    Mess.find({}, function(err, messages) {
        if(err) {
            console.log(err);
        }
        else {
            res.render('index', {messages});
        }
    })
})

app.post('/addMess', function(req, res) {
    console.log("add new message");
    console.log("Post Data", req.body);
    var mess = new Mess(req.body);
    console.log(mess);
    mess.save(function(err) {
        if(err) {
            console.log("something went wrong");
            console.log(mess.errors);
            res.render('/', {errors: mess.errors})
        }
        else {
            console.log("Added new message!");
            res.redirect('/');
        }
    })
})

app.post('/addComm', function(req, res) {
    console.log("add new comment");
    console.log("Post Data", req.body);
    Comm.create(req.body, function(err, data) {
        if(err){
            console.log("something went wrong");
            console.log(data.errors);
            res.render('/', {errors: data.errors});
        }
        else{
            Mess.findOneAndUpdate({_id: req.body.id}, {$push: {comments:data}}, function(err, data) {
                if(err) {
                    console.log("something went wrong");
                    console.log(data.errors);
                    res.render('/', {errors: data.errors})
                }
                else {
                    console.log("Added new comment!");
                    res.redirect('/');
                }
            })
        }
    })
})

app.listen(8000, function() {
    console.log("listening on port 8000");
});