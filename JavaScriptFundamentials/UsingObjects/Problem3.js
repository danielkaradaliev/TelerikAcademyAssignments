//Problem 3. Deep copy
//
//Write a function that makes a deep copy of an object.
//    The function should work for both primitive and reference types.

function deepCopy(object){
    return JSON.parse(JSON.stringify(object));
}

var animal1 = {
    name: 'Sharo',
    age: 3,
    breed: 'Dog'
};

var animal2 = deepCopy(animal1);

console.log(animal1);
console.log(animal2);