//Problem 1. Reverse string
//
//Write a JavaScript function that reverses a string and returns it.
//    Example:
//
//input	    output
//sample	elpmas

var inputString,
    reversedString = '',
    len;

function reverseString(str) {
        len = str.length-1;

    if (!str) {
        return str;
    }

    for(var i = len; i >= 0; i--){
        reversedString += str[i];
    }

    return reversedString;
}

inputString = 'sample';
reversedString = reverseString(inputString);

console.log(reversedString);