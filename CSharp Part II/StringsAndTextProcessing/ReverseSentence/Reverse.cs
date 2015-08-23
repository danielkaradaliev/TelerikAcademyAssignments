//Problem 13. Reverse sentence
//Write a program that reverses the words in given sentence.
//Example:
//input	                                    output
//C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Reverse
{
    static void Main()
    {
        Console.WriteLine("Enter a string!");
        //string input = "C# is not C++ not PHP and not Delphi!";
        string input = Console.ReadLine();
        string output = "";
        char sign = input[input.Length - 1];
        input = input.Remove(input.Length - 1, 1);
        string[] words = input.Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
         Array.Reverse(words);
        output = string.Join(" ", words);
        Console.WriteLine(output);
    }
}