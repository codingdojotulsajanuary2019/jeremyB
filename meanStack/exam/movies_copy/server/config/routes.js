const Movies = require('./../controllers/movies');

module.exports = (app) => {
    app.get('/movies', Movies.all)
    app.post('/movies/new', Movies.create)
    app.put('/movies/:id/review', Movies.review)
    app.get('/movies/:id', Movies.show)
    app.delete('/movies/delete/:id', Movies.destroy)
    app.put('/movies/delete/:id/:rev', Movies.delRev)
}