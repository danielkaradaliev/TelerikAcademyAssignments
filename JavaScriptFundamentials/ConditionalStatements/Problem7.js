//Problem 7. The biggest of five numbers
//
//Write a script that finds the greatest of given 5 variables.
//    Use nested if statements.
//    Examples:
//
//a	    b	    c	    d	    e	    biggest
//5	    2	    2	    4	    1	    5
//-2	-22	    1	    0	    0	    1
//-2	4	    3	    2	    0	    4
//0	    -2.5	0	    5	    5	    5
//-3	-0.5	-1.1	-2	    -0.1	-0.1

//Change input data here:
var a = -3;
var b = -0.5;
var c = -1.1;
var d = -2;
var e = -0.1;

if (a > b && a > c && a > d && a > e) {
    console.log(a);
}
else if (b > a && b > c && b > d && b > e) {
    console.log(b);
}
else if (c > a && c > b && c > d && c > e) {
    console.log(c);
}
else if (d > a && d > b && d > c && d > e) {
    console.log(d);
}
else {
    console.log(e);
}