$(document).ready(function() {
    var socket = io();

    socket.on('background', function(data) {
        console.log(data);
        $('body').css('background-color', data.color);
    })

    $('button').click(function() {
        bcolor = $(this).attr('id');
        console.log(bcolor,"clicked");
        socket.emit('color', {color:bcolor});
    })

})