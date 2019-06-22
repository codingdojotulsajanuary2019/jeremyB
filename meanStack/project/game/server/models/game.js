const mongoose = require('mongoose');

const GameSchema = new mongoose.Schema({
    player: {type: String, required: [true, 'Need a name to play!']},
    gold: {type: Number}
})

mongoose.model('Game', GameSchema);