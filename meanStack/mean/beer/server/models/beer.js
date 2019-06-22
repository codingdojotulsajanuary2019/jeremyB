const mongoose = require('mongoose');

const BeerSchema = new mongoose.Schema({
    brewer: {type: String, required: [true, 'Brewer is required!'], minlength: [2, 'Brewer must be 2 characters long!']},
    img: {type: String, required:[true, 'Image is required!']},
    review: [
        {
            comment: {type: String, required:[true, "Comment required"]},
            rate: {type: Number, required:[true, "Rating required"]}
        }
    ],
    rating: {type: Number}
}, {timestamps: true});

mongoose.model('Beer', BeerSchema);