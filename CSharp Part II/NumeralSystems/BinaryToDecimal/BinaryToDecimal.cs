//Problem 2. Binary to decimal
//Write a program to convert binary numbers to their decimal representation.
using System;
class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number:");
        string binnum = Console.ReadLine();
        long decnum = Convert.ToInt64(binnum, 2);
        Console.WriteLine("{0} in decimal: {1}",binnum,decnum);
    }
}