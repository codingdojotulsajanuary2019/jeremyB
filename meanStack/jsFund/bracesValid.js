function braceV(str){
    var arr = []
    for(var i = 0; i<str.length; i++){
        if(str[i] == "(" || str[i] == "[" || str[i] =="{"){
            arr.push(str[i]);
        }
        else if(str[i] == ")"){
            console.log(1)
            if(arr.pop() != "("){
                return false;
            }
        }
        else if(str[i] == "]"){
            console.log(2)
            if(arr.pop() != "["){
                return false;
            }
        }
        else if(str[i] == "}"){
            console.log(3)
            if(arr.pop() != "{"){
                return false;
            }
        }
    }
    if(arr.length != 0){
        return false;
    }
    else{
        return true;
    }
}
console.log(braceV("[{{{}}}{()()}"));