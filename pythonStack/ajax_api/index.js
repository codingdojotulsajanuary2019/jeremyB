$(document).ready(function(){
    // $.get()
    // $.post()
    for(var i=1; i<280; i++) {
        $('div.wrapper').append(`<img src=https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/shiny/${i}.png alt='pokemon' value=${i}>`);
    }

    $(document).on("click","img",function(){
        id = ($(this).attr('value'));
        html_str = "";

        $.ajax({
            method: 'get',
            url: 'https://pokeapi.co/api/v2/pokemon/'+id,
            dataType: 'json',
            success: function(res){
                console.log(res.types.type)

                html_str +='<h2>' +res.name.charAt(0).toUpperCase() + res.name.slice(1) + '</h2>'
                html_str += '<img class="pokedex_img" src=' + res.sprites.front_default + '>'
                html_str += '<h4>Types</h4>'
                for(var i=0; i < res.types.length; i++) {
                    html_str += '<p>' + res.types[i].type.name + '<p>'
                }
                html_str += '<h4>Height</h4>'
                html_str += '<p>' + res.height + '<p>'
                html_str += '<h4>Weight</h4>'
                html_str += '<p>' + res.weight + '<p>'
                $('div.pokedex').html(html_str);
            }
        })
    })
})

// $.ajax({
//     method:'get',
//     url: 'https://pokeapi.co/api/v2/pokemon/1'
// })

// $.ajax({
//     method: 'get',
//     url: 'https://pokeapi.co/api/v2/pokemon/'+i,
//     // data: send post data
//     dataType: 'json',
//     success: function(res) {
//         // get the info form the request
//         console.log(res);
//         $('div.wrapper').append(`<img src=${res.sprites.front_shiny} alt='pokemon' value=${i}>`);
//     },
//     error: function(err) {
//         // server error
//     },
//     complete: function(next) {
//         // regardless of success or error, this will run
//         console.log('in done method');
//     }
// })
// console.log('after the ajax method');