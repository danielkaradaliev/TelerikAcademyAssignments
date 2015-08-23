//Problem 23. Series of letters
//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:
//input	                    output
//aaaaabbbbbcdddeeeedssaa	abcdedsa
using System;
class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string output = input[0].ToString();
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != output[output.Length - 1])
            {
                output += input[i];
            }
        }
        Console.WriteLine(output);
    }
}