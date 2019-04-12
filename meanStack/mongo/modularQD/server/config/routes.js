const quotes = require('../controllers/quotes.js');

module.exports = function(app){
// Routes
// Root Request
app.get('/', function(req, res) {
    quotes.index(req, res);
})
// Add User Request 
app.post('/quotes', function(req, res) {
   quotes.new(req, res);
})

app.get('/quotes', function(req, res){
    quotes.quotes(req, res);
})
}