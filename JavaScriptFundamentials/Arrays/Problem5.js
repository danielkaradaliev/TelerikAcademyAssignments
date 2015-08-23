//Problem 5. Selection sort
//
//Sorting an array means to arrange its elements in increasing order.
//    Write a script to sort an array.
//    Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
//    Hint: Use a second array

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

selectionSort(arr);
console.log(arr);