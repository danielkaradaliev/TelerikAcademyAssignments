//Problem 1. Odd or Even
//Write an expression that checks if given integer is odd or even.
// //Examples:
//n	    Odd?
//3	    true
//2	    false
//-2	false
//-1	true
//0	    false

//change the input value here
var value = 0;

if(value < 0){
    value = value*(-1);
}
console.log(value%2==1);