/*Problem 3. The biggest of Three

Write a script that finds the biggest of three numbers.
    Use nested if statements.
    Examples:

a	    b	    c	    biggest
5	    2	    2	    5
-2	    -2	    1	    1
-2	    4	    3	    4
0	    -2.5	5	    5
-0.1	-0.5	-1.1	-0.1 */

//Change input data here:
var a = -0.1;
var b = -0.5;
var c = -1.1;
var flag;

if(a == b && b == c) {
    console.log(a);
}
else if (a > b) {
    flag = a;
    if(flag > c) {
        console.log(flag);
    }
    else {
        console.log(c);
    }
}
else {
    flag = b;
    if(flag > c){
        console.log(flag);
    }
    else{
        console.log(c);
    }
}