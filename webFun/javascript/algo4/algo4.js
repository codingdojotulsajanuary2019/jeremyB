function gTY (arr, y){
    var count = 0;
    var newArr = [];
  
    for(var i = 0; i<arr.length;i++){
      if(y<arr[i]){
        count++;
        newArr.push(arr[i]);
      }
    }
      console.log("count: "+ count + " array: " + newArr);
}

function minMaxAvg(arr){
    var min = arr[0];
    var max = arr[0];
    var sum = arr[0];
    for (var i = 1; i<arr.length; i++){
        if(arr[i] > max){
            max = arr[i];
        }
        else if (arr[i] < min){
            min = arr[i];
        }
        sum = sum + arr[i];
    }
    var avg = sum/arr.length;
    return [min, max, avg];
}

function repNeg(arr){
    var newArr = [];
    for(var i = 0; i<arr.length; i++){
        if(arr[i] < 0){
            newArr[i] = "Dojo";
        }
        else{
            newArr[i] = arr[i];
        }
    }
    return newArr;
}

function remVal(arr, start, end){
    var diff = end - start + 1;
    for (var i = end+1; i<arr.length; i++){
        var temp = arr[i-diff];
        arr[i-diff]=arr[i];
        arr[i] = temp;
    }
    arr.length = arr.length-diff;
    return arr;
}