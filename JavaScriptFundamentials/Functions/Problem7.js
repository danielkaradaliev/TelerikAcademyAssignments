//Problem 7. First larger than neighbours
//
//Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
//    Use the function from the previous exercise.

//I didn't figure out how to use the function from the previous problem, so i wrote a new one instead!

function firstBiggerNumber(arr) {
    var returnedIndex = 0,
        i = 0,
        len = arr.length;
    if(len == 1){
        console.log("No neighbours!");
        return;
    }
    for(;i < len - 1;i += 1) {
        if(arr[i] > arr[i-1] && arr[i] > arr[i+1]) {
            returnedIndex = i;
            console.log("The index of the first number,bigger than its neighbours is %d", returnedIndex);
            return;
        }
    }
    console.log("No appropriate index to return!");
}

var arr = [-2, 6, 8, 5, 3, 3733, -8, 239];
firstBiggerNumber(arr);