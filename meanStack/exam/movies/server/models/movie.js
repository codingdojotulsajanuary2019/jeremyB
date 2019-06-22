const mongoose = require('mongoose');

const MovieSchema = new mongoose.Schema({
    title: {type: String, required: [true, 'Title is required!'], minlength: [3, 'Title must be 3 characters long!']},
    review: [
        {
            name: {type: String, require:[true, "Name is required"], minlength: [3, 'Name must be 3 characters long!']},
            comment: {type: String, required:[true, "Review is required"], minlength: [3, 'Review must be 3 characters long!']},
            stars: {type: Number, required:[true, "Rating is required"], min:[1, "Rating is required"]}
        }
    ],
    rating: {type: Number}
}, {timestamps: true});

mongoose.model('Movie', MovieSchema);