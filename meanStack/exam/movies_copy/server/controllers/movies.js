const mongoose = require('mongoose');
const Movie = mongoose.model('Movie');

module.exports = {
    all: (req, res) => {
        console.log("all route");
        Movie.find({}, (err, movies) => {
            if(err){
                res.json({status: false, error: err});
            } else {
                res.json({status: true, movies: movies})
            }
        })
    },
        
    create: (req, res) => {
        console.log("create route");
        console.log(req.body);
        const movie = new Movie(req.body);
        movie.rating = movie.review[0].stars;

        movie.save((err) => {
            if(err){
                res.json({status:false, error:err});
            } else {
                res.json({status: true, movie: movie})
            }
        })
    },

    review: (req, res) => {
        console.log("review route");
        console.log(req.body);
        Movie.findOne({_id: req.params.id}, (err, movie) => {
            if(err){
                console.log("error")
                res.json({status:false, error:err});
            } else {
                console.log("no error")
                console.log(movie.review);
                let sum = 0;
                movie.review.push(req.body);
                for (let x in movie.review){
                    if(movie.review[x].stars){
                        console.log("if statment");
                        console.log(movie.review[x].stars);
                        sum += movie.review[x].stars;
                    }
                }
                let avg = sum/movie.review.length;
                console.log(avg);
                movie.rating = avg;
                console.log(movie.rating)
                
                movie.save((err) => {
                    if(err){
                        res.json({status: false, error: err})
                    } else {
                        console.log("Rating, in theory");
                        res.json({status: true});
                    }
                })
            }
        })
    },

    show: (req, res) => {
        console.log("Show route");
        const movieId = req.params.id;
        Movie.findOne({_id:movieId}, (err, movie)=>{
            if(err){
                res.json({status:false, error:err});
            } else {
                res.json({status: true, movie:movie});
            }
        })
    },

    destroy: (req, res) =>{
        console.log("destroy route");
        console.log(req.params);
        console.log(req.body);
        console.log(req.params.id);
        const id = req.params.id;
        console.log(id);
        Movie.deleteOne({_id:id}, (err, movie)=>{
            if(err){
                res.json({status:false, error:err});
            }
            else{
                res.json({status:true, movie: movie})
            }
        })
    },
    
    delRev: (req, res) => {
        console.log("delRev route");
        console.log(req.params);
        console.log(req.params.id)
        console.log(req.params.rev)
        Movie.findOne({_id: req.params.id}, (err, movie) => {
            if(err){
                console.log("error")
                res.json({status:false, error:err});
            } else {
                console.log("no error")
                console.log(movie.review);
                movie.review.splice(req.params.rev,1);
                console.log(movie.review);

                let sum = 0;
                for (let x in movie.review){
                    if(movie.review[x].stars){
                        console.log("if statment");
                        console.log(movie.review[x].stars);
                        sum += movie.review[x].stars;
                    }
                }
                let avg = sum/movie.review.length;
                console.log(avg);
                movie.rating = avg;
                console.log(movie.rating)
                
                movie.save((err) => {
                    if(err){
                        res.json({status: false, error: err})
                    } else {
                        console.log("Removed a review");
                        res.json({status: true});
                    }
                })
            }
        })
    }
}