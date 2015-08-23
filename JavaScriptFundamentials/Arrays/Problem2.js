//Problem 2. Lexicographically comparison
//
//Write a script that compares two char arrays lexicographically (letter by letter).

var arr1 = ["Y", "O", "U", "T", "U", "B", "E", ".", "C", "O", "M"];
var arr2 = ["V", "I", "B", "O", "K", "S", "7", ".", "C", "O", "M"];

for(var i = 0; i < arr1.length; i++) {
    if(arr1[i] == arr2[i]) {
        console.log("Elements with index " + i + " match!");
    }
    else {
        console.log("Elements with index " + i + " DO NOT match!")
    }
}
