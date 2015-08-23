//Problem 3. Occurrences of word
//
//Write a function that finds all the occurrences of word in a text.
//    The search can be case sensitive or case insensitive.
//    Use function overloading.

function countStringOccurrencesInText(text, pattern) { //source: https://github.com/azsum/JSexam/blob/master/functions%20JS.js
    text = text.toLowerCase();                         //In case this is you, thank you!
    var count = 0;
    for (var i = 0; i < text.length; i++) {
        text = text.replace(pattern, "*");
        if (text[i] === '*') {
            count++;
        }
    }
    return count;
}

var string = "one two three one four six two five one";
var searchFor = "one";
var result = "";

result = countStringOccurrencesInText(string, searchFor);
console.log("Occurrences: %d", result);