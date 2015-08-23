//Problem 2. Reverse number
//
//Write a function that reverses the digits of given decimal number.
//    Example:
//
//input	    output
//256	    652
//123.45	54.321

function reverse(input) {
    var result = "",
        i,
        len = input.length;
    input = input + "";
    for(i = len - 1; i >= 0; i -= 1) {
        result += input[i];
    }
    return result;
}

var number = 3733;
var output = reverse(number);

console.log(output);