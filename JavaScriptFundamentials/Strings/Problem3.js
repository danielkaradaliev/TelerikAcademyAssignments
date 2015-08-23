//Problem 3. Sub-string in text
//
//Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
//Example:
//
//    The target sub-string is in
//
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//
//The result is: 9

var inputString,
    inputSubstring,
    result,
    pos,
    i,
    substrLen,
    strLen,
    count = 0;

function getSubstringCount(str, substr){
    str = str.toLowerCase();
    substr = substr.toLowerCase();
    i = str.indexOf(substr);
    substrLen = substr.length;
    strLen = str.length;

    while (i > -1) {
        count++;
        pos = i + substrLen;
        if (pos >= strLen-1) {
            break;
        }
        i = str.indexOf(substr, pos);
    }

    return count;
}

inputString = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
inputSubstring = 'in';
result = getSubstringCount(inputString,inputSubstring);

console.log(result);