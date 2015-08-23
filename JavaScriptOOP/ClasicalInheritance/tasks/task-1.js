/* Task Description */
/*
 Create a function constructor for Person. Each Person must have:
 *	properties `firstname`, `lastname` and `age`
 *	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
 *	age must always be a number in the range 0 150
 *	the setter of age can receive a convertible-to-number value
 *	if any of the above is not met, throw Error
 *	property `fullname`
 *	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
 *	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
 *	it must parse it and set `firstname` and `lastname`
 *	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
 *	all methods and properties must be attached to the prototype of the Person
 *	all methods and property setters must return this, if they are not supposed to return other value
 *	enables method-chaining
 */
function solve() {
    var Person = (function () {
        function Person(firstname, lastname, age) {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        Object.defineProperties(Person.prototype,
            {
                'firstname' : {
                    get : function () {
                        return this._firstname;
                    },
                    set: function (x) {
                        checkLetters(x);
                        checkNameLength(x);

                        this._firstname = x;
                        return this;
                    }
                },
                'lastname' : {
                    get : function () {
                        return this._lastname;
                    },
                    set : function (x) {
                        checkLetters(x);
                        checkNameLength(x);

                        this._lastname = x;
                        return this;
                    }
                },
                'age' : {
                    get : function () {
                        return this._age;
                    },
                    set : function (x) {
                        checkIfAgeIsNumber(x);
                        checkAge(x);

                        this._age = x;
                        return this;
                    }
                },
                'fullname' : {
                    get : function () {
                        return this.firstname + ' ' + this.lastname;
                    },
                    set : function (x) {
                        var names = x.split(' ');
                        this.firstname = names[0];
                        this.lastname = names[1];
                    }
                }
            });

        Person.prototype.introduce = function () {
            return 'Hello! My name is ' +  this.fullname + ' and I am ' + this.age + '-years-old';
        };

        function checkNameLength (x) {
            var len = x.length;

            if(len < 3 || len > 20) {
                throw new Error('Name should be between 3 and 20 characters long!');
            }
        }

        function checkLetters(x) {
            var pattern = /[^A-Za-z]/g;
            if (pattern.test(x)) {
                throw new Error('Name should contain only letters');
            }
        }

        function checkAge (x) {
            if(x < 0 || x > 150) {
                throw new Error('Age should be between 0 and 150');
            }
        }

        function checkIfAgeIsNumber (x) {
            x = x * 1;
            if(!x) {
                throw new Error('Age should be a number!');
            }
        }

        return Person;
    } ());
    return Person;
}
module.exports = solve;