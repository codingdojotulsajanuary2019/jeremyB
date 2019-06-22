const Beers = require('./../controllers/beers');

module.exports = (app) =>{
    app.get('/beers', Beers.all)
    app.post('/beers', Beers.create)
    app.put('/beers/:id', Beers.review)
    app.get('/beers/:id', Beers.show)
}