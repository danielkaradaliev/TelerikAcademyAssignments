//Problem 7. Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
//Examples:
//numbers	            sum
//1 2 3 4 5	            15
//10 10 10 10 10	    50
//1.5 3.14 8.2 -1 0     11.84
using System;
class Sum
{
    static void Main()
    {
        double sum=0;
        string numbers = Console.ReadLine(); //Input numbers separated by spaces
        string[] splitInput = numbers.Split(new Char[] {' '});
        double[] nums = Array.ConvertAll<string, double>(splitInput, double.Parse); //Converts the inputed string into an array
        for(int i=0;i<5;i++)
        {
            sum = sum + nums[i];
        }
        Console.WriteLine(sum);
    }
}