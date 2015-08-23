//Problem 2. Reverse string
//Write a program that reads a string, reverses it and prints the result at the console.
//Example:
//input	    output
//sample	elpmas
using System;
class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Input String!");
        string input = Console.ReadLine();
        string output = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            output += input[i];
        }
        Console.WriteLine("Result: {0}", output);
    }
}