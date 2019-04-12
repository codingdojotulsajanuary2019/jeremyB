const mongoose = require('mongoose');
const Ninja = mongoose.model('Ninja');

module.exports = {
    ind: (req, res) => {
        console.log("Ind function (frogs)");
        let ninja = new Ninja();
        ninja.save((err) => {
            if (err) {
                res.json({
                    success: false,
                    error: err
                });
            } else {
                console.log("hi");
                res.json({
                    success: true,
                    ninja: ninja
                });
            }
        })
    },
    game: (req, res) => {
        Ninja.find({_id: req.params.id}, (err, game) => {
            if(err){
                res.json({status: false, error: err});
            }
            else{
                res.json({status: true, game: game})
            }
        })
    },
    addGold: function (req, res) {
        console.log("Update Route");
        let game;
        let actions = [];
        Ninja.findOne({_id: req.params.id}, (err, game) => {
            if(err){
                console.log("Did not find ninja!")
                res.json({status: false, error: err});
            }
            else{
                console.log("got it");
                console.log(game);
                console.log(req.body);
                game.score += req.body.gold;
                game.actions.push(req.body.action);
                game.save(err => {
                    if(err){
                        console.log("failure");
                        res.json({status: false, err:err});
                    }
                    else{
                        console.log("success");
                        res.json({status: true, game: game});
                    }
                });
                };
                
            })
    }
    // getLeaderboard: (req, res) => {
    //     Ninja.find({}, ['score'], {
    //         limit: 5,
    //         sort: {
    //             score: -1
    //         }
    //     }, (err, ninjas) => {
    //         if (err) {
    //             res.json({
    //                 success: false,
    //                 error: err
    //             });
    //         } else {
    //             res.json({
    //                 success: true,
    //                 ninjas: ninjas
    //             });
    //         }
    //     })
    // }
}