const Authors = require('../controllers/authors');

module.exports = (app)=>{
    app.get('/authors', Authors.index)
    app.post('/add', Authors.create)
    // app.delete('/delete/:id', Authors.destroy)
    app.get('/info/:id', Authors.show)
    // app.put('/update/:id', Authors.update)
}