//Problem 6. Most frequent number
//
//Write a script that finds the most frequent number in an array.
//    Example:
//
//input	                                    result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	    4 (5 times)

var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
var currentSequence = 0;
var maxSequence = 0;
var frequentNumCandidate = 0;

for (var i = 0; i < arr.length - 1; i++) {

    for (var j = 0; j <= arr.length - 1; j++) {

        if (arr[i] === arr[j]) {
            currentSequence ++;

            if (currentSequence > maxSequence) {
                maxSequence = currentSequence;
                frequentNumCandidate = arr[i];
            }
        }
    }
    currentSequence = 0;
}

console.log(frequentNumCandidate + ' (' + maxSequence + ' times)');