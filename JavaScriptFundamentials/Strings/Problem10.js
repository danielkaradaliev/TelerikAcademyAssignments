//Problem 10. Find palindromes
//
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

function isPalindrome(str){
    var len = str.length;
    middleI = (len / 2) | 0;

    for (var i = 0;i < middleI; i += 1) {
        if (str[i] !== str[len - 1 - i]) {
            return false;
        }
    }
    return true;
}

var arrWithWords = ["ABBA", "Smokie", "lamal", "yahoo", "exe", "Jamba", "kapak"],
    i,
    len = arrWithWords.length;

for(i = 0; i < len; i += 1) {
    if(isPalindrome(arrWithWords[i])) {
        console.log(arrWithWords[i] + " is palindrome!")
    }
}