function bubSort(arr){
    for (var i = 0; i < arr.length; i++){
        count = 0;
        for(var j = 0; j < arr.length-1; j++){
            if(arr[j] > arr[j+1]){
                temp = arr[j+1];
                arr[j+1] = arr[j];
                arr[j] = temp;
                count++
            }
        }
        if (count == 0){
            return arr
        }
    }
}
console.log(bubSort([5,3,4,7,2,10, 1]));