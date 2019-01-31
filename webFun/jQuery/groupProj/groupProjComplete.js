$(document).ready(function(){
    console.log("document ready")

    $('button.down').click(function(){
        console.log("button press")
        $('p.down').slideDown("slow", function(){
            console.log("slide down");
        });
    });

    $('button.up').click(function(){
        console.log("button press")
        $('p.down').slideUp("slow", function(){
            console.log("slide up");
        });
    });

    $('button.toggle').click(function(){
        console.log("button press")
        $('p.toggle').slideToggle("slow", function(){
            console.log("slide toggle");
        });
    });

    $('button.after').click(function(){
        console.log("button press")
        $('p.after').after("add more text ")
            console.log("after");
    });

    $('button.attr').click(function(){
        console.log("button press")
        $('p.attr').attr("href", "background-color:red")
            console.log("attr");
    });

    $('button.hide').click(function(){
        console.log("button press")
        $('p.hide').hide()
            console.log('hide');
    });
    $('button.show').click(function(){
        console.log("button press")
        $('p.hide').show()
            console.log('show');
    });
    $('button.toggle').click(function(){
        console.log("button press")
        $('p.toggle').toggle()
            console.log('toggle');
    });
    $('button.fIn').click(function(){
        console.log("button press")
        $('p.fade').fadeIn()
            console.log('fade in');
    });
    $('button.fOut').click(function(){
        console.log("button press")
        $('p.fade').fadeOut()
            console.log('fade out');
    });

});

//Group 1
// $('document').ready(function(){
//     alert("jQuery Started");

//     $('.show').hide();
//     $('hide').show();

//     $('button.togglebtn').click(function()
//     {
//         console.log("BUTTON CLICKED")
//         $('.hide').toggle();

//     });

//     $('button.before').click(function()
//     {
//         $('p.add').before("<p>THIS IS A NEW PARAGRAPH</p>")
//     });

//     $("button.html").click(function()
//     {
//         $("p").html("This was changed by the HTML Button")
//     })

//     $("button.showbtn").click(function()
//     {
//         $('.show').show()
//     });

//     $('button.hidebtn').click(function()
//     {
//         $('.hide').hide()
//     });
// });

// Group 3
// $(document).ready(function(){
//     $("h1").click(function(){
//         $(this).addClass("red");
//     });
//     $(".body").click(function(){
//         $(".body p").fadeIn("slow",function(){
//         });
//     });
//     $("p").click(function(){
//          $(this).fadeOut("fast");
//     });
//     $("button").click(function(){
//         $(".para").append("<p>Answers answers answers answers...............</p><hr>")
//     });
//     $("input").click(function(){
//         $("input").val("Skylar")
//     })    
// });
