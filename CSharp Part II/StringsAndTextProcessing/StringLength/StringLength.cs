//Problem 6. String length
//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.
using System;
class StringLength
{
    static void Main()
    {
        Console.WriteLine("Enter string(Of maximum 20 chars):");
        string input = Console.ReadLine();
        string output = "";
        int InputLength = input.Length;
        output = input;
        if(InputLength < 20)
        {
            for(int i = InputLength;i<20;i++)
            {
                output += "*";
            }
        }
        Console.WriteLine(output);

    }
}