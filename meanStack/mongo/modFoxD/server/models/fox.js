var mongoose = require('mongoose');
var validate = require('mongoose-validator');
var nameValidator = [
    validate({
        validator:'isLength',
        arguments:[2,20],
        message: 'Name must be between {ARGS[0]} and {ARGS[1]} letters.',
    }),
    validate({
        validator:'isAlpha',
        passIfEmpty: true,
        message: 'Name should only contain letters.'
    })
]
var foodValidator = [
    validate({
        validator: 'isLength',
        arguments: [3],
        message: 'Food must be longer than {ARGS[0]} chracters',
    })
]
var ageValidator = [
    validate({
        validator: 'isNumeric',
        message: 'Age must be a number',
    })
]

var FoxSchema = new mongoose.Schema({
    name: {type: String, required: [true, 'Need a name!'], validate: nameValidator},
    age: {type: Number, required:[true, 'Has to have an age!'], min:1, max: [20, "Foxes only live until 20"], validate: ageValidator},
    food: {type: String, required: [true, "Gotta eat something!"], validate: foodValidator}
   }, {timestamps: true});
mongoose.model('Fox', FoxSchema);
module.exports = mongoose.model('Fox') 