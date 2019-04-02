$(document).ready(function(){
    $(document).on("click", "button", function(){
        var info;
        $.get("https://api.github.com/users/jbenedik", function(data){
            console.log(data);
            info = data.name;
            console.log(info); 
            
            $('h3').html(info);
        });
    })
});