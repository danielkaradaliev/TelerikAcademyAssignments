//Problem 1. Planar coordinates
//
//Write functions for working with shapes in standard Planar coordinate system.
//    Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.
//    Check if three segment lines can form a triangle.

function buildPoint(X, Y) {
    var P = {
        x: X,
        y: Y
    };
    return P;
}

function buildLine(P1, P2) {
    var L = {
        point1: P1,
        point2: P2,
        distance: function() {
            var a = Math.max(this.point1.x, this.point2.x) - Math.min(this.point1.x, this.point2.x);
            var b = Math.max(this.point1.y, this.point2.y) - Math.min(this.point1.y, this.point2.y);
            return Math.sqrt(a * a + b * b);
        }
    };
    return L;
}

function formATriangleMaybe(L1, L2, L3) {
    if (((L1 + L2) > L3) && ((L1 + L3) > L2) && ((L3 + L2) > L1)) {
        console.log('Yes');
    } else {
        console.log('Sorry, but no');
    }
}

var point1 = buildPoint(0, 5),
    point2 = buildPoint(5, 7),
    point3 = buildPoint(-2, 8);

var line1= (buildLine(point1, point2)),
    line2 = (buildLine(point2, point3)),
    line3 = (buildLine(point3, point1));

console.log('line1 distance: %d', line1.distance());
console.log('line2 distance: %d', line2.distance());
console.log('line3 distance: %d', line3.distance());

formATriangleMaybe(line1,line2,line3);