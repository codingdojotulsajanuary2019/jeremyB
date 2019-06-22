$(document).ready(function() {
    $('form').submit(function(e) {
        console.log("I'm a big dummy");
        e.preventDefault();

        survey = {
            name : $('#name').val(),
            location : $('#location').val(),
            language : $('#lang').val(),
            comment : $('#comment').val(),
        }             
        console.log(survey);
        var socket = io();
        socket.emit('survey', survey);
        socket.on('msg', function(data) {
            $('.msg').html(
                `<p>${data.msg}</p>
                <p>${data.lucky}</p>`
            )
        })
    })
})