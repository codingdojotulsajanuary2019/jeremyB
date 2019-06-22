const mongoose = require('mongoose');

const AuthorSchema = new mongoose.Schema({
    name: {type: String, required:[true, 'Name is required'], minlength:[3, "Must be 3 characters long"]},
});

mongoose.model('Author', AuthorSchema);