var express = require('express');
var app = express();
var bodyParser = require('body-parser');
var path = require('path');
const flash = require('express-flash');

app.use(bodyParser.urlencoded({ extended: true }));
app.use(express.static(path.join(__dirname, './static')));
app.set('views', path.join(__dirname, './views'));
app.set('view engine', 'ejs');

require('./server/config/routes.js')(app)
require('./server/config/mongoose.js')

app.listen(8000, function() {
  console.log("listening on port 8000");
});