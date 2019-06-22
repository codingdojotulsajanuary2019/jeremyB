const mongoose = require('mongoose');
const Author = mongoose.model('Author');

module.exports = {
    index: (req, res) => {
        console.log("index route");
        Author.find({}, (err, authors) =>{
            if(err){
                console.log("err");
                res.json({status: false, error: err});
            }
            else{
                console.log("authors");
                res.json({status: true, authors: authors})
            }
        })
    },
    create: (req, res) => {
        console.log("create route")
        console.log(req.body);
        const author = new Author(req.body);
        author.save((err) => {
            if(err){
                res.json({status: false, error: err});
            }
            else{
                res.json({status: true, author: author})
            }
        })
    },

}