//Problem 2. Divisible by 7 and 5
//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
//    Examples:
//n	Divided by 7 and 5?
//3	    false
//0	    true
//5	    false
//7	    false
//35	true
//140	true

//Change value here
var value = 140;

console.log(value % 7 == 0 && value % 5 == 0);