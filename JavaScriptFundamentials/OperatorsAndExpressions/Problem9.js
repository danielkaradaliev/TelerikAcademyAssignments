//Problem 9. Point in Circle and outside Rectangle
//Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out
// of the rectangle R(top=1, left=-1, width=6, height=2).
//    Examples:
//x	    y	    inside K & outside of R
//1	    4	    yes
//3	    2	    yes
//0	    1	    no
//4	    1	    no
//2	    0	    no
//4	    0	    no
//2.5	1.5	    yes
//3.5	1.5	    yes
//-100	-100	no

//Change x and y here:
var xCoord = -100;
var yCoord = -100;

var hCentre = 1;
var kCentre = 1;
var radius = 3;

var pointInCircle = function(x,y,hc,kc,r){
    var dx = x - hc;
    var dy = y - kc;
    var circle = (dx*dx) + (dy*dy);
    var diameter = r * r;
    var isInCircle = circle <= (diameter);
    return isInCircle;
};

var checkRectangle = (xCoord < -1) || (xCoord > 5) || (yCoord < -1) || (yCoord > 1);
var checkCircle = pointInCircle(xCoord,yCoord,hCentre,kCentre,radius);
if (checkCircle && checkRectangle) {
    console.log('yes');
}
else {
    console.log('no');
}