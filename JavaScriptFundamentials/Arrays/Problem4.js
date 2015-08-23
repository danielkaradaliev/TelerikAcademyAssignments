//Problem 4. Maximal increasing sequence
//
//Write a script that finds the maximal increasing sequence in an array.
//    Example:
//
//input	                    result
//3, 2, 3, 4, 2, 2, 4	    2, 3, 4

var arr = [3, 2, 3, 4, 2, 2, 4];
var longestSequence = 0;
var currentSequence = 0;
var result = "";
var sequenceIndex;

for (var i = 1; i < arr.length; i++){
    if(arr[i] > arr[i - 1]){
        currentSequence+=1;
        if(currentSequence > longestSequence){
            longestSequence = currentSequence;
            sequenceIndex = i;
        }
    }else{
        currentSequence = 1;
    }
}
result = arr.splice(sequenceIndex - longestSequence + 1, longestSequence).join(', ');

console.log(result);