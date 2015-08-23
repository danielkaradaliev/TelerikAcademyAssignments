//Problem 5. Youngest person
//
//Write a function that finds the youngest person in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.
//
//    Example:
//
//var people = [
//    { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
//    { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];

function youngestPerson(arr) {
    len,
    youngest = arr[0].age;
    for (var i = 1, len = arr.length; i < len; i+=1) {
        if (youngest > arr[i].age) {
            youngest = arr[i].age;
        }
    }
    return youngest;
}

var somePeople = [
    { firstname : 'Ivan', lastname: 'Ivanov', age: 56 },
    { firstname : 'Stamat', lastname: 'Stamatov', age: 25},
    { firstname : 'Georgi', lastname: 'Georgiev', age: 16 },
    { firstname : 'Joro', lastname: 'Jorev', age: 8 }
];

console.log(youngestPerson(somePeople));