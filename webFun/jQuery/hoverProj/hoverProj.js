$(document).ready(function(){

    $('img').hover(function(){
        // var firstSrc = $(this).attr('src');
        // var altSrc = $(this).attr('data-alt-src');

        $(this).attr('src','img/dogs.jpg');
        // $(this).attr('data-alt-src',firstSrc);
        },

        function() {
        $(this).attr('src','img/effie.jpg');
        // $(this).attr('data-alt-src',firstSrc);
        
        }
    
    );

});