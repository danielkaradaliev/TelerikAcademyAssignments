//Problem 3. Min/Max of sequence
//
//Write a script that finds the max and min number from a sequence of numbers.

//Change the sequence here:
var numbers = [12, 8, 7, 6, 22, 98, 102, -9,0, 18, 3733];
var min = Math.pow(2, 53) - 1;      //Max safe integer
var max = -(Math.pow(2, 53) - 1);   //Min safe integer

for(var i = 0;i < numbers.length; i++){
    if(numbers[i] > max){
        max = numbers[i];
    }
    if(numbers[i] < min){
        min = numbers[i];
    }
}
console.log("min: " + min);
console.log("max: " + max);