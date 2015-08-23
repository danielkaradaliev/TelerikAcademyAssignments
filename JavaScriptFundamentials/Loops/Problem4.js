//Problem 4. Lexicographically smallest
//
//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

var min;
var max;
var prop;

minMax(document);
minMax(window);
minMax(navigator);

function minMax(obj) {

    min = '~'; //126 in ASCII
    max = ' '; //32 in ASCII

    for (prop in obj) {

        if (prop > max) {
            max = prop;
        }
        if (prop < min) {
            min = prop;
        }
    }

    console.log(obj.toString() + ': min -> ' + min + ', max -> ' + max);
}