//Problem 6. Divisible by 7 and 3
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
using System;
using System.Linq;

delegate void SimpleDelegate(string param);

class DivisibleBy7And3
{
    static void Main()
    {
        var array = new[] { 5, 8, 6, -11, -7, 7, 21, -21, 84, 0 };

        var numbersDevisibleBy7And3 = array.Where(x => (x % 3 == 0 && x % 7 == 0));
        foreach (var number in numbersDevisibleBy7And3)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

        var numbersDevisibleBy7And3LINQ =
            from number in array
            where (number % 3 == 0 && number % 7 == 0)
            select number;
        foreach (var number in numbersDevisibleBy7And3LINQ)
        {
            Console.WriteLine(number);
        }
    }
}