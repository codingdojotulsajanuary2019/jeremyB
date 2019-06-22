const mongoose = require('mongoose');

const UserSchema = new mongoose.Schema({
    name: {type: String, required: [true, 'Need a name!'], minlength: [2, "Name must be two characters long!"]},
    email: {type: String, required: [true,'Need email!']},
    pword: {type: String, required:[true, 'Need password']},

});

