const ninjas = require('../controllers/ninjas');

module.exports = function(app) {
    app.get('/ninja', ninjas.ind)
    app.get('/:id', ninjas.game)
    app.put('/:id/updateGold', ninjas.addGold)
}
