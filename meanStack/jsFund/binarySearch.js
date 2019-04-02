function binSearch(arr, start, end, num){
    console.log(start);
    console.log(end);
    mid = Math.floor((start+end)/2);
    console.log(mid);
    console.log("-------------------------------------------")
    if(start == end || start > end){
        console.log("not in there");
        return -1;
    }
    if (arr[mid] == num){
        console.log("Got it!");
        return mid;
    }
    else if (arr[start] == num){
        console.log("Got it!");
        return start;
    }
    else if (arr[end] == num){
        console.log("Got it!");
        return end;
    }
    else if (num > arr[mid]){
        console.log("num greater than");
        binSearch(arr,mid+1, end-1, num);
    } 
    else{
        console.log("num less than");
        binSearch(arr, start+1, mid-1, num);
    }
}

var arr = [1, 3, 8, 10, 12, 15, 17, 20, 22, 34, 38, 40, 50, 52, 78, 87, 90, 91, 92, 94]
var len = arr.length;
console.log(binSearch(arr,0, len, 87));