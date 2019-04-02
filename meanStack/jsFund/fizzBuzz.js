function fzBz(n){
    if(typeof(n) != "number"){
        console.log("plz send num");
    }
    if(n<0){
        console.log("plz make biger");
    }
    var str = ""
    for(i = 1; i<=n; i++){
        if(i%3 == 0 && i%5 == 0){
            str += "FizzBuzz, ";
        }
        else if(i%3 == 0){
            str += "Fizz, ";
        }
        else if(i%5 == 0){
            str += "Buzz, ";
        }
        else{
            str += i
            str += ", "
        }
    }
    console.log(str);
}
fzBz("potato");
fzBz(-15);
fzBz(15);
