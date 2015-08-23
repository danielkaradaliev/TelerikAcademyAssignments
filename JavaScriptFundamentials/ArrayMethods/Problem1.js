//Problem 1. Make person
//
//Write a function for creating persons.
//    Each person must have firstname, lastname, age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and genders

function makePerson(firstname, lastname, age, gender) {
    return {
        firstName: firstname,
        lastName: lastname,
        age: age,
        gender: gender
    };
}
var arrWithPeople = [
    makePerson('Ivan', 'Ivanov', 20, false),
    makePerson('Ivanka', 'Ivanova', 34, true),
    makePerson('Traqn', 'Georgiev', 59, false),
    makePerson('Janeta', 'Petrova', 41, true),
    makePerson('Georgi', 'Georgiev', 29, false),
    makePerson('Petranka', 'Jelqzkova', 20, true),
    makePerson('Petyr', 'Georgiev', 33, false),
    makePerson('Svetla', 'Dimitrova', 26, true),
    makePerson('Uliqn', 'Vuchkov', 85, false),
    makePerson('Hristiqna', 'Koleva', 17, true)
    ],
    females,
    sum,
    average,
    minAge,
    youngestPerson,
    groupedPeople;

arrWithPeople.forEach(function (item, index) {
    console.log('Index' + index + ' ' + JSON.stringify(item));
});

console.log();

//Problem 2. People of age
//
//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//Use only array methods and no regular loops (for, while)

if(arrWithPeople.every(function(person) {
            return person.age >= 18;
        }
    )) {
    console.log('All the people in the array are above 18 years old');
}
else {
    console.log('Not all the people in the array are above 18 years old');
}

console.log();

//Problem 3. Underage people
//
//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while)

console.log('Underage people:' );
arrWithPeople.filter(function(person){
    if(person.age < 18)
        console.log(person);
});

console.log();

//Problem 4. Average age of females
//
//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)

females = arrWithPeople.filter(function(person){
        return person.gender;});
    sum = females.reduce(function(sum,females){
        sum += females.age;
        return sum;
    }, 0);
    average = sum/(females.length);
console.log("Females in the array(If any):");
console.log(females);
console.log('Average age of females: ' + average);
console.log();

//Problem 5. Youngest person
//
//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//    Use Array#find

function printYoungestPersonsFullname(arr) {
    minAge = arr[0].age;
    arr.forEach(function (element) {
        if (minAge > element.age && !element.gender) {
            minAge = element.age;
        }
    });

    youngestPerson = arr.filter(function (item) {
        if (item.age === minAge) {
            return item;
        }
    });

    return youngestPerson[0].firstName + ' ' + youngestPerson[0].lastName;
}

console.log('Youngest male person: ' + printYoungestPersonsFullname(arrWithPeople));
console.log();

//Problem 6. Group people
//
//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)
//    Example:
//
//        result = {
//            'a': [{
//                firstname: 'Asen',
//                /* ... */
//            }, {
//                firstname: 'Anakonda',
//                /* ... */
//            }],
//            'j': [{
//                firstname: 'John',
//                /* ... */
//            }]
//        };

groupedPeople = arrWithPeople.reduce(function(obj, person) {
    if (obj[person.firstName[0]]) {
        obj[person.firstName[0]].push(person);
    } else {
        obj[person.firstName[0]] = [person];
    }
    return obj;
}, {});

console.log(groupedPeople);