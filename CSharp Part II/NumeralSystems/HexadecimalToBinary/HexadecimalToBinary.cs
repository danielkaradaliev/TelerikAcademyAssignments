//Problem 5. Hexadecimal to binary
//Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;
class HexadecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number: ");
        string hexnum = Console.ReadLine();
        string binnum = Convert.ToString(Convert.ToInt64(hexnum, 16), 2);
        Console.WriteLine("{0} (hex) in binary: {1}",hexnum,binnum);
    }
}