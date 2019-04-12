const foxes = require('../controllers/foxes.js');

module.exports = function(app){

app.get('/', function(req, res) {
    foxes.index(req, res);
})

app.get('/foxes/new', function(req, res) {
    foxes.newPage(req, res);
})

app.post('/foxes', function(req, res) {
    foxes.newFox(req, res);
})

app.get('/foxes/:id', function(req, res){
    foxes.foxInfo(req, res);
})

app.get('/foxes/edit/:id', function(req, res) {
    foxes.editPage(req, res);
})

app.post('/foxes/:id', function(req, res) {
    foxes.editFox(req, res);
})

app.post('/foxes/destroy/:id', function(req, res) {
    foxes.killFox(req, res);
})
}