//Biggie Size
function makeItBig(arr){
    for(var i=0; i<arr.length;i++){
        if(arr[i]>0){
            arr[i]="big";
        }       
    }
    return arr;
}

//Print Low, Return High
function lowHigh(arr){
    var low = arr[0];
    var high = arr[0];
    for(var i=1; i<arr.length;i++){
        if(low > arr[i]){
            low = arr[i];
        }
        if(high < arr[i]){
            high = arr[i];
        }
    }
    console.log(low);
    return high;
}

//Print One, Return Another
function oneAnother(arr){
    var toEnd=arr[arr.length-2];
    var firstOdd=0;
    for(var i=0; i<arr.length;i++){
        if(arr[i]%2 != 0){
            firstOdd=arr[i];
            break;
        }
    }
    console.log(toEnd);
    return firstOdd;
}

//Double Vision
function doubleVision(arr){
    var doubleArr = [];
    for(var i=0; i<arr.length; i++){
        doubleArr[i] = arr[i] * 2;
    }
    return doubleArr;
}

//Count Positives
function countPositives(arr){
    var count = 0;
    for(var i=0; i<arr.length; i++){
        if(arr[i] > 0){
            count++;
        }
    }
    arr[arr.length-1] = count;
    return arr;
}

//Evens and Odds
function evenOdds(arr){
    for(var i=0; i<arr.length; i++){
        if(arr[i]%2 == 0 && arr[i+1]%2 == 0 && arr[i+2]%2 == 0){
            console.log("Even more so!");
        }
        else if(arr[i]%2 != 0 && arr[i+1]%2 != 0 && arr[i+2]%2 != 0){
            console.log("That's odd!");
        }
    }
}

//Increment the Seconds
function incrementSeconds(arr){
    for(var i = 0; i<arr.length; i++){
        if(i%2 !=0){
            arr[i] = arr[i] + 1;
        }
        console.log[arr.i];
    }
    return arr;
}

//Previous Lengths
function prevLengths(arr){
    for(var i=arr.length-2; i>-1; i--){
        arr[i+1] = arr[i].length;
    }
    return arr;
}

//Add Seven to Most
function addSeven(arr){
    var newArr = [];
    for(var i=0; i<arr.length; i++){
        newArr[i] = arr[i] + 7;
    }
    return newArr;
}

//Reverse Array
function reverseArr(arr){
    var temp = 0;
    for(var i=0; i<arr.length/2; i++){
        temp = arr[i];
        arr[i] = arr[arr.length-i-1];
        arr[arr.length-i-1] = temp;
    }
    return arr;
}

//Outlook: Negative
function negative(arr){
    var newArr = [];
    for(var i = 0; i<arr.length; i++){
        if(arr[i] > 0){
            newArr[i] = arr[i] * -1;
        }
        else{
            newArr[i] = arr[i];
        }
    }
    return newArr;
}

// Always Hungry
function alwaysHungry(arr){
    var count = 0;
    for (var i=0; i<arr.length; i++){
        if(arr[i]=="food"){
            console.log("yummy");
            count ++;
        }
    }
    if(count == 0){
        console.log("I'm hungry");
    }
}

//Swap Toward the Center
function swapCenter(arr){
    var temp = 0;
    for(var i = 0; i<arr.length/2; i+=2){
        temp = arr[i];
        arr[i] = arr[arr.length-i-1];
        arr[arr.length-i-1] = temp;
    }
    console.log(arr);
}

//Scale the Array
function scaleArr(arr, num){
    for(var i = 0; i<arr.length; i++){
        arr[i] = arr[i] * num;
    }
    return arr;
}
