//print 1 to x
function printUpTo(x){
    if(x<1){
        return false;
    }
    else{
        for(i=1;i<x;i++){
            console.log(i);
        }
    }   // your code here
  }
  printUpTo(1000); // should print all the integers from 1 to 1000
  y = printUpTo(-10); // should return false
  console.log(y); // should print false

//printSum
function printSum(x){ //your code here
    var sum = 0;
    for(i=0;i<x+1;i++){
        console.log(i);
        sum = sum + i;
    }
    return sum
  } 
  y = printSum(255) // should print all the integers from 0 to 255 and with each integer print the sum so far.
  console.log(y) // should print 32640

//printSumArray
  function printSumArray(x){
    var sum = 0;
    for(var i=0; i<x.length; i++) {
      sum = sum + x[i];//your code here
    }
    return sum;
  }
  console.log( printSumArray([1,2,3]) ); // should log 6

  //LargestElement
  function largestElement(x){
    var max = 0; 
    for(var i=0; i<x.length; i++){
        if(x[i] > max){
            max = x[i];
        }      
      }
    return max;
  }