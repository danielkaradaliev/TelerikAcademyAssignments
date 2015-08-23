//Problem 6. Sum integers
//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:
//input	                output
//"43 68 9 23 318"	    461
using System;
using System.Linq;
class SumIntegers
    {
    static int CalculateSum(string input)
    {
        int sum = 0;
        int[] arr = input.Split(' ').Select(str => int.Parse(str)).ToArray();
        for(int i = 0; i<arr.Length;i++)
        {
            sum += arr[i];
        }
        return sum;
    }
        static void Main()
        {
            int sum = 0;
            Console.WriteLine("Enter String: ");
            string input = Console.ReadLine();
            //string input = "43 68 9 23 318";
            sum = CalculateSum(input);
            Console.WriteLine("The sum is: {0}",sum);
        }
    }