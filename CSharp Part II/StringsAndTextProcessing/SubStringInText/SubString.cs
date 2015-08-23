//Problem 4. Sub-string in text
//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9
using System;
using System.Linq;
class SubString
{
    static void Main()
    {
        Console.Write("Enter a substring: ");
        string SubString = Console.ReadLine();
        Console.WriteLine("Enter a text where we are going to looking for our target substring:");
        string text = Console.ReadLine();
        int br = 0;
        br = text.Select((c, i) => text.Substring(i)).Count(sub => sub.StartsWith(SubString));
        Console.WriteLine("{0} is contained {1} times in the text!",SubString,br);
    }
}