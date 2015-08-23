//Problem 8. Binary short
//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;
class BinaryShort
{
    static void Main()
    {
        Console.WriteLine("Enter \"Short\" number:");
        short decnum = short.Parse(Console.ReadLine());
        string binnum = Convert.ToString(decnum, 2);
        Console.WriteLine("{0} in binary: {1}",decnum,binnum);
    }
}