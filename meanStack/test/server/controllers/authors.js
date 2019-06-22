const mongoose = require('mongoose');
const Author = mongoose.model('Author');

module.exports = {
    all: (req, res) => {
        console.log("Pull all");
        Author.find({}, (err, authors) => {
            if(err) {
                res.json({status: false, error: err});
            }
            else {
                res.json({status: true, authors: authors})
            }
        })
    },

    create: (req, res) => {
        console.log('Create Route');
        console.log(req.body);
        const author = new Author(req.body);
        author.save((err) => {
            if(err) {
                res.json({status: false, error: err});
            }
            else {
                res.json({status: true, author: author})
            }
        })
    }
}