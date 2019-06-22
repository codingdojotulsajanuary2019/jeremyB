$(document).ready(function() {
    var name = prompt('Please enter your name');
    console.log(name);
    if(name == null || name ==""){
        location.reload();
    }
    else{
        var socket = io();
        socket.on('messages', function(data) {
            console.log(data);
            console.log(data.all);
            for(let x in data.all){
                $('.all').append(`<p><span style="color:purple">${data.all[x].name}:</span> ${data.all[x].message} `)
            }
        })

        socket.on('aMsg', function(data) {
            console.log(data);
            $('.all').append(`<p><span style="color:red">You:</span> ${data.all.message} `)
        })

        $('#msgbtn').click(function() {
            let message = $('.msg').val();
            console.log(message);
            socket.emit('new', {
                name : name,
                message: message
            });
            $('.msg').val('');
        })
    }
})