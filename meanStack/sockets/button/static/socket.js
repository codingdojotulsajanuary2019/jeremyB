$(document).ready(function() {
    var socket = io();

    $('#btn').click(function() {
        console.log("clicked the button")
        socket.emit('count', {count:1});
        socket.on('user2', function(data) {
            $('.num').html(`The button has been pushed ${data.count} time(s)`);
        })
        
    })
    $('#res').click(function() {
        socket.emit('reset', {count:"reset"});
        socket.on('user', function(data) {
            $('.num').html("The button has been reset");
        })
    })
})