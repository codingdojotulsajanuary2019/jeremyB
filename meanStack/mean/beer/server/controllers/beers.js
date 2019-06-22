const mongoose = require('mongoose');
const Beer = mongoose.model('Beer');

module.exports = {
    all: (req, res) => {
        console.log("all route");
        Beer.find({}, (err, beers) => {
            if(err){
                res.json({status: false, error: err});
            } else {
                res.json({status: true, beers: beers})
            }
        })
    },
    
    create: (req, res) => {
        console.log("create route");
        console.log(req.body);
        const beer = new Beer(req.body);

        beer.save((err) => {
            if(err){
                res.json({status:false, error:err});
            } else {
                res.json({status: true, beer: beer})
            }
        })
    },
    review: (req, res) => {
        console.log("review route");
        console.log(req.body);
        Beer.findOne({_id: req.params.id}, (err, beer) => {
            if(err){
                console.log("error")
                res.json({status:false, error:err});
            } else {
                console.log("no error")
                let sum = 0;
                beer.review.push(req.body);
                for (let x in beer.review){
                    if(beer.review[x].rate){
                        console.log("if statment");
                        console.log(beer.review[x].rate);
                        sum += beer.review[x].rate;
                    }
                }
                let avg = sum/beer.review.length;
                console.log(avg);
                beer.rating = avg;
                console.log(beer.rating)
                
                beer.save((err) => {
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
        const beerId = req.params.id;
        Beer.findOne({_id:beerId}, (err, beer)=>{
            if(err){
                res.json({status:false, error:err});
            } else {
                res.json({status: true, beer:beer});
            }
        })
    }
}