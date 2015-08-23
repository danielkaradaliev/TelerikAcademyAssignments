//Problem 6. Binary to hexadecimal
//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary number: ");
        string binnum = Console.ReadLine();
        string hexnum = Convert.ToString(Convert.ToInt64(binnum, 2), 16);
        Console.WriteLine("{0} (bin) in hexadecimal: {1}",binnum,hexnum);
    }
}