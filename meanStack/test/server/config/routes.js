const Authors = require('./../controllers/authors');
const Users = require('../controllers/users');

module.exports = (app) => {
    app.get('/authors', Authors.all)
    app.post('authors/new', Authors.create)
}