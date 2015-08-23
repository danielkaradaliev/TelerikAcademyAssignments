//Problem 5. nbsp
//
//Write a function that replaces non breaking white-spaces in a text with &nbsp;

function replaceWhiteSpace(text) {
    return (text.split(/\s/g).join('&nbsp;'));
}

var input = "some text some text some text",
    output = replaceWhiteSpace(input);

console.log(output);