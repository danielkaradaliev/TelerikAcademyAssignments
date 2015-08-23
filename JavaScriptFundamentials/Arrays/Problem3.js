//Problem 3. Maximal sequence
//
//Write a script that finds the maximal sequence of equal elements in an array.
//    Example:
//
//input	                            result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1	    2, 2, 2

var sequence = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
var currentNumber;
var currentLength = 1;

var longestNumber;
var longestLength = 0;

var result = "";

for(var i = 1;i< sequence.length;i++) {
    if(sequence[i] == sequence[i-1]) {
        currentLength ++;
        currentNumber = sequence[i];
        if(currentLength > longestLength) {
            longestLength = currentLength;
            longestNumber = currentNumber;
        }
    }
    else {
        currentLength = 1;
    }
}

result = longestNumber;
for(;(longestLength - 1) > 0; longestLength --) {
    result += ", " + longestNumber;
}

console.log(result);