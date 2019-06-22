const mongoose = require('mongoose');
const Task = mongoose.model('Task');

module.exports = {
    index: (req, res) =>{
        console.log("index route");
        console.log(req.method);
        Task.find({}, (err, tasks) =>{
            if(err){
                res.json({status: false, error: err});
            }
            else{
                res.json({status: true, tasks: tasks})
            }
        })
    },
    create: (req, res) =>{
        console.log("create route");
        console.log(req.body);
        const task = new Task(req.body.newtask);

        task.save((err) => {
            if(err){
                console.log("getting here bitch");
                res.json({status: false, error: err});
            }
            else{
                console.log("should be a coming");
                res.json({status: true, task: task})
            }
        })
    },
    show: (req, res) =>{
        console.log("show route");
        console.log(req.method);
        const title = req.params.title;
        Task.findOne({title:title}, (err, task)=>{
            if(err){
                res.json({status:false, error:err});
            }
            else {
                res.json({status:true, task: task})
            }
        })
    },
    update: (req, res) =>{
        console.log("update route");
        console.log(req.body);
        Task.findOneAndUpdate({title: req.params.title}, {$set: {
            completed: req.body.newinfo.completed,
            description: req.body.newinfo.description,
            title: req.body.newinfo.title
        }}, {new:true}, (err, task)=> {
            if(err){
                res.json({status:false, error:err});
            }
            else {
                console.log(task);
                res.json({status:true, task: task})
            }
        })
    },
    destroy: (req, res) =>{
        console.log("destroy route");
        console.log(req.pararms);
        console.log(req.body);
        const title = req.params;
        console.log(title);
    Task.deleteOne({_id:title.title}, (err, task)=>{
            if(err){
                res.json({status:false, error:err});
            }
            else{
                res.json({status:true, task: task})
            }
        })
    },
}