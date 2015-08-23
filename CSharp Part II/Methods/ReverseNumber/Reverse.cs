//Problem 7. Reverse number
//Write a method that reverses the digits of given decimal number.
//Example:
//input 	output
//256	    652
//123.45	54.321
using System;
class ReverseNumber
    {
    static string Reverse(string number)
    {
        string output = "";
        for(int i = number.Length-1;i>=0;i--)
        {
            output = output + number[i];
        }
        return output;
    }
        static void Main()
        {
            Console.Write("Enter Number:");
            string num = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Reversed:");
            Console.WriteLine(Reverse(num));
        }
    }