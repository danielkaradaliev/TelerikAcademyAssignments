//Problem 2. Numbers not divisible
//
//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

//Change input data here:
var N = 1000;

for(var i = 1;i <= N;i++){
    if(i % 3 != 0 && i % 7 != 0){
        console.log(i);
    }
}