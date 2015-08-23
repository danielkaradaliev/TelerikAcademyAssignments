//Problem 7. Binary search
//
//Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

function findIndex(values, target) {    //source: http://algorithms.openmymind.net/search/binarysearch.html
    return binarySearch(values, target, 0, values.length - 1);
}

function binarySearch(values, target, start, end) {
    if (start > end) { return -1; } //does not exist

    var middle = Math.floor((start + end) / 2);
    var value = values[middle];

    if (value > target) { return binarySearch(values, target, start, middle-1); }
    if (value < target) { return binarySearch(values, target, middle+1, end); }
    return middle; //found!
}

//The function from Problem5 (I am using it in order to sort tha array)!
function selectionSort (sortMe) //source: http://en.wikibooks.org/wiki/Algorithm_Implementation/Sorting/Selection_sort
{
    var i, j, tmp, tmp2;
    for (i = 0; i < sortMe.length - 1; i++) {
        tmp = i;
        for (j = i + 1; j < sortMe.length; j++) {
            if (sortMe[j] < sortMe[tmp]) {
                tmp = j;
            }
        }
        if (tmp != i) {
            tmp2 = sortMe[tmp];
            sortMe[tmp] = sortMe[i];
            sortMe[i] = tmp2;
        }
    }
}

var arr = [10, 6, 8, 9, 2, 11, -8, 0, -9, 20, 3733, -100, 10];
var target = 8;
var result = "";

selectionSort(arr);
console.log(arr);
result = findIndex(arr, target);
console.log(result);


