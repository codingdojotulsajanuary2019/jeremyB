$(document).ready(function(){
    console.log("document ready")

    $('img').click(function(){
        console.log("clicked");
        $(this).hide(function(){
            console.log("hide");
        });
    });

    $('button').click(function(){
        console.log("button");
        $('img').show(function(){
            console.log("button trigger")
        });
    });
});