//Problem 6.
//
//Write a function that groups an array of people by age, first or last name.
//    The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
//Use function overloading (i.e. just one function)
//
//Example:
//
//var people = {…};
//var groupedByFname = group(people, 'firstname');
//var groupedByAge= group(people, 'age');

var person,
    len;
function Person(firstname, lastname, age) {
    if (!(this instanceof  Person)) {
        return new Person(firstname, lastname, age);
    }

    this.firstname = firstname;
    this.lastname = lastname;
    this.age = age;
}

Person.prototype.toString = function(){
    return this.firstname + ' ' + this.lastname;
};

function comparePeople(a, b) {
    return a.age - b.age;
}

var people = [
    new Person('Stamat', 'Stamatov', 35),
    new Person('Ivan', 'Ivanov', 22),
    new Person('Ganka', 'Gankova', 23)
];

people.sort(comparePeople);

for (person = 0, len = people.length; person < len; person += 1) {
    console.log(people[person]);
}

console.log('Youngest: ' + people[0].toString());