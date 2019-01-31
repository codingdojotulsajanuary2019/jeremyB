//Sigma
function sigma(num){
    var sum = 0;
    for(var i = 1; i <= num; i++){
        sum = sum + i;
    }
    return sum;
}

//Factorial
function factorial(num){
    var facto = 1;
    for(var i = 1; i<= num; i++){
        facto = facto * i;
    }
    return facto;
}

//Fibonacci
function fibonacci(num){
    var fibArr = [0,1];
    if(num > 1){
        for(var i = 2; i <= num; i++){
            fibArr[i] = fibArr[i-1]+fibArr[i-2];
        }
    }
    return fibArr[num];
}

//Array: Second-to-Last
function secondToLast(arr){
    if(arr.length > 2){ 
        return arr[arr.length-2];
    }
    else{
        return null;
    }
}

//Array: Nth-to-Last
function nthToLast(arr, n){
    if (arr.length < n){
        return null;
    }
    else{
        return arr[arr.length-n];
    }
}

//Array: Second-Largest
function secondLargest(arr){
    var first = 0;
    var second = 0;
    if(arr.length > 2){
        for(var i = 0; i < arr.length; i++){
            if(arr[i] > first){
                second = first;
                first = arr[i];
            }
            else if (arr[i] > second && arr[i] != first){
                second = arr[i];
            }
        }
        return second;   
    }
    else{
        return null;
    }
}

//Double Trouble
function doubleTrouble(arr){
    var newLeng = arr.length * 2;
    var leng = arr.length
    for(var j = leng; j>0; j--){
        arr.push(0);
    }
    for(var k = newLeng-2; k>0; k-=2){
        arr[k] = arr[k/2]; 
    }
    for(var i = 0; i<newLeng; i+=2){
        arr[i+1]=arr[i];
    }
    return arr;
} 

//Fibonnaci Recursive
function recursiveFib(num){
    if(num==0 || num==1){
        return num;
    }
    return recursiveFib(num-2) + recursiveFib(num-1);
}