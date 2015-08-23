//Problem 4. Hexadecimal to decimal
//Write a program to convert hexadecimal numbers to their decimal representation.
using System;
class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter Hexadecimal number: ");
        string hexnum = Console.ReadLine();
        long decnum = Convert.ToInt64(hexnum, 16);
        Console.WriteLine("{0} in decimal : {1}",hexnum,decnum);
    }
}