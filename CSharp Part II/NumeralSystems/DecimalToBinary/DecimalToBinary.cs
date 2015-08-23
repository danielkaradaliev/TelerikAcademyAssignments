//Problem 1. Decimal to binary
//Write a program to convert decimal numbers to their binary representation.
using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        long decnum = long.Parse(Console.ReadLine());
        string binnum = Convert.ToString(decnum, 2);
        Console.WriteLine("{0} in binary: {1}",decnum,binnum);
    }
}