//Problem 6. Quadratic equation
//
//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Calculates and prints its real roots.
//    Note: Quadratic equations may have 0, 1 or 2 real roots.
//
//    Examples:
//
//  a	    b	    c	    roots
//  2	    5	    -3	    x1=-3; x2=0.5
//  -1	    3	    0	    x1=3; x2=0
//  -0.5	4	    -8	    x1=x2=4
//  5	    2	    8	    no real roots

//Change input data here:
var a = 5;
var b = 2;
var c = 8;

var D = (b * b) - (4 * a * c);
if(D < 0){
    console.log("no real roots");
}
else if(D == 0){
    var x = (-b) / (2 * a);
    console.log("x1 = x2 = " + x);
}
else {
    var x1 = ((-b) - Math.sqrt(D)) / (2 * a);
    var x2 = ((-b) + Math.sqrt(D)) / (2 * a);
    console.log("x1 = " + x1 + "; x2 = " + x2);
}