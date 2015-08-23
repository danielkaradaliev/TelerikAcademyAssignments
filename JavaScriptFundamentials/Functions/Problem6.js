//Problem 6. Larger than neighbours
//
//Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).

function biggerNumber(position, arr) {
    if(arr.length == 1) {
        console.log("No neighbours!");
        return;
    }
    if((position == 0) || position == arr.length - 1 ) {
        console.log("The number does not have two neighbours!");
        return;
    }
    if(position < 0 || position >=arr.length) {
        console.log("This position does not exists!");
        return;
    }
    if((position > 0) && position < arr.length - 1) {
        if ((arr[position - 1] < arr[position]) && (arr[position + 1] < arr[position])) {
            console.log("True!");
        }
        else {
            console.log("False!");
        }
    }
}

var arr = [-2, 6, 8, 5, 3, 3733, -8, 239];
var position = 7;

biggerNumber(position,arr);