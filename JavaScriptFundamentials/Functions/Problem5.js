//Problem 5. Appearance count
//
//Write a function that counts how many times given number appears in given array.
//Write a test function to check if the function is working correctly.

function countNumbers(lookFor, arr) {
    var count = 0;
    for(var i = 0; i < arr.length; i++) {
        if(arr[i] == lookFor) {
            count ++;
        }
    }
    return count;
}

function testFunction(expectedOutput,output) {
    if(output === expectedOutput) {
        console.log("Correct!");
    }
    else {
        console.log("Error!");
    }
}

var arr = [3,4,5,1,0,1,8,9,6,7,3733,1,1,0,22];
var lookFor = 1;
var expectedOutput = 4;

var output = countNumbers(lookFor, arr);
testFunction(expectedOutput, output);