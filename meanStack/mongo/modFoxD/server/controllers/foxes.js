var Fox = require('../models/fox');

module.exports = {
    index: function(req, res) {
        console.log("index page");
        Fox.find({}, function(err, foxes) {
            if(err){
                console.log(err);
            } else {
                res.render('index', {foxes: foxes});
            }
        })
    },
    newPage: function(req, res) {
        console.log("Got to new display page");
        res.render('new');
    },
    newFox: function(req, res) {
        console.log("POST DATA", req.body);
        var fox = new Fox(req.body);
        console.log(fox);
        fox.save(function(err) {
            if(err) {
                console.log("Something went wrong");
                console.log(err);
                console.log(fox.errors);
                res.render('new', {errors: fox.errors})
            }
            else {
                console.log("Successfully added a fox!");
                console.log(fox.errors);
                res.redirect('/');
            }
        })
    },
    foxInfo: function(req, res) {
        console.log("info page");
        console.log(req.params.id);
        Fox.findOne({_id:req.params.id}, function(err, fox) {
            if(err) {
                return console.log(err);
            }
            else {
                console.log(fox);
                res.render('info', {fox});
            }
        })
    },
    editPage: function(req, res) {
        console.log("edit page");
        console.log(req.params.id);
        Fox.findOne({_id:req.params.id}, function(err, fox) {
            if(err) {
                console.log(err);
            }
            else {
                console.log(fox);
                res.render('edit', {fox});
            }
        })
    },
    editFox: function(req, res) {
        console.log("update route");
        console.log("POST DATA", req.body);
        Fox.update({_id:req.params.id},
            { name: req.body.name,
            age: req.body.age,
            food: req.body.food},
            function(err) {
                if(err) {
                    console.log("error");
                    console.log(err);
                    res.redirect(`foxes/edit/${req.params.id}`)
                }
                else {
                    console.log("Successfully updated a fox!");
                    res.redirect(`/foxes/${req.params.id}`);
                }
        })
    },
    killFox: function(req, res) {
        console.log("Delete route")
        Fox.deleteOne({_id:req.params.id}, function(err) {
            if(err){
                console.log(err);
                res.redirect('/');
            }
            else{
                console.log("Record deleted")
                res.redirect('/');
            }
        })
    }
}