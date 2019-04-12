var mongoose = require('mongoose');

var QuoteSchema = new mongoose.Schema({
    name: {type: String, required: true, minlength:6 },
    quote: {type: String, required: true, minlength: 18} 
   }, {timestamps: true});

mongoose.model('Quote', QuoteSchema);
module.exports = mongoose.model('Quote');