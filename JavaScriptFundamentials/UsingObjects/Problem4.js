//Problem 4. Has property
//
//Write a function that checks if a given object contains a given property.
//
//    var obj  = …;
//var hasProp = hasProperty(obj, 'length');

function hasProperty(obj, prop) {
    if (prop in obj) {
        return console.log(obj +' has a property '+ prop);
    } else {
        return console.log(obj +' does NOT have a property '+ prop);
    }
}

var animal = {
    name: 'Sharo',
    age: 3,
    breed: 'Dog',
    saySomething: 'Bau!'
    };

console.log(animal.name);
hasProperty(animal, 'saySomething');