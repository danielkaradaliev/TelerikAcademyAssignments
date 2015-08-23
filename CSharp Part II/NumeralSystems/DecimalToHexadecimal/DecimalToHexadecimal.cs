//Problem 3. Decimal to hexadecimal
//Write a program to convert decimal numbers to their hexadecimal representation.
using System;
class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        long decnum = long.Parse(Console.ReadLine());
        string hexnum = decnum.ToString("X");
        Console.WriteLine("{0} in hexadecimal : {1}",decnum,hexnum);
    }
}