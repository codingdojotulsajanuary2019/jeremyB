var mongoose = require('mongoose');

var NinjaSchema = new mongoose.Schema({
    score: {type: Number, default: 0},
    actions: {type: Array, default: []}
   }, {timestamps: true});
mongoose.model('Ninja', NinjaSchema);
module.exports = mongoose.model('Ninja') 
