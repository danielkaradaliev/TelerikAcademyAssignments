//Problem 2. Correct brackets
//
//Write a JavaScript function to check if in a given expression the brackets are put correctly.
//    Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

var inputString,
    a = 0,
    b = 0,
    i= 0,
    ch = '',
    len,
    correctBrackets;
function areTheBracketsCorrect(str) {
    for (i = 0, len = str.length; i < len; i += 1) {
        ch = str[i];
        if (ch == '(') {
            a += 1;
        }
        else if (ch == ')') {
            b += 1;
        }
    }
    if (a == b) {
        return true;
    }
    else {
        return false;
    }
}

inputString = ')(a+b))';
correctBrackets = areTheBracketsCorrect(inputString);

console.log(correctBrackets);