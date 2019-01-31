//Get 1 to 255
function countTo255(){
    var arr=[];
    for(var i=1; i<256; i++){
        arr.push(i);
    }
    return arr;
}

//Get even 1000
function even1000(){
    var sum=0;
    for(var i=2; i<1001; i+=2){
        sum= sum + i;
    }
    return sum;
}

//Sum odd 5000
function sumOdd5000(){
    var sum=0;
    for(var i=1; i<5000; i+=2){
        sum= sum+i;
    }
    return sum;
}

//Iterate an array
function iterateArray(arr){
    var sum=0;
    for(var i=0; i<arr.length; i++){
        sum = sum + arr[i];
    }
    return sum;
}

//Find Max
function findMax(arr){
    var max = arr[0];
    for(var i=0; i<arr.length; i++){
        if(max < arr[i]){
            max = arr[i];
        }
    }
    return max;
}

//Find average
function findAvg(arr){
    var sum = arr[0];
    for(var i =1; i<arr.length; i++){
        sum = sum + arr[i];
    }
    return sum/arr.length;
}

//Array odd
function arrayOdd(){
    var arr = [];
    for(var i=1; i<50; i+=2){
        arr.push([i]);
    }
    return arr;
}

//Greater than Y
function greaterThanY(y, arr){
    var count = 0;
    for(var i=0; i< arr.length; i++){
        if(arr[i]>y){
            count++;
        }
    }
    return count;
}

//Squares
function squares(arr){
    for(var i=0; i<arr.length; i++){
        arr[i] = arr[i]*arr[i];
    }
    return arr;
}

//Negatives
function negatives(arr){
    for(var i=0; i<arr.length; i++){
        if(arr[i]<0){
            arr[i]=0;
        }
    }
    return arr;
}

//Max/Mix/Avg
function maxMinAvg(arr){
    var min = arr[0];
    var sum = arr[0];
    var max = arr[0];

    for(var i=1; i<arr.length; i++){
        if(arr[i]>max){
            max = arr[i];
        }
        if(arr[i]<min){
            min = arr[i];
        }
        sum = sum + arr[i];
    }
    var avg = sum/arr.length;
    return [min, max, avg];
}

//Swap Values
function swapValues(arr){
    var temp = arr[0];
    arr[0] = arr[arr.length-1];
    arr[arr.length-1]=temp;
    return arr;
}

//Number to String
function numberToString(arr){
    for(var i=0; i<arr.length; i++){
        if(arr[i]<0){
            arr[i]="Dojo";
        }
    }
    return arr;
}