//Problem 1. Format with placeholders
//
//    Write a function that formats a string. The function should have placeholders, as shown in the example
//Add the function to the String.prototype
//Example:
//
//    input	                                                            output
//var options = {name: 'John'};
//'Hello, there! Are you #{name}?'.format(options);	'                   Hello, there! Are you John'
//var options = {name: 'John', age: 13};
//'My name is #{name} and I am #{age}-years-old').format(options);	    'My name is John and I am 13-years-old'

String.prototype.format = function(options) {
    var prop,
        result = this;
    for (prop in options) {
        result = result.replace(new RegExp('#{' + prop + '}', 'g'), options[prop]);
    }
    return result;
};

var options01 = { name: 'John' };
var options02 = { name: 'John', age: 13 };
var string01 = 'Hello, there! Are you #{name}?';
var string02 = 'My name is #{name} and I am #{age}-years-old';

console.log(string01.format(options01));
console.log(string02.format(options02));