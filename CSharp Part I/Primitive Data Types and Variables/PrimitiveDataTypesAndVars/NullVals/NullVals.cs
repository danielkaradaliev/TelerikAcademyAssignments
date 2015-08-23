//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
using System;
class NullVals
{
    static void Main()
    {
        int? someInt = null;
        double? someDouble = null;
        Console.WriteLine(someInt);
        Console.WriteLine(someDouble);
        someInt += 5;
        someDouble += 5;
        Console.WriteLine(someInt);
        Console.WriteLine(someDouble);
    }
}