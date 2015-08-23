////Problem 13. Binary to Decimal Number
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:
//binary	                    decimal
//0	                            0
//11	                        3
//1010101010101011	            43691
//1110000110000101100101000000	236476736
using System;
class BinToDec
{
    static void Main()
    {
        string input = Console.ReadLine();
        int lastIndex = input.Length - 1;
        long dec = 0;
        for (int i = 0; i < input.Length; i++, lastIndex--)
        {
            if (input[i].ToString().Contains("1"))
            {
                long binarySum = 1;
                for (int j = 0; j < lastIndex; j++)
                {
                    binarySum *= 2;
                }
                dec += binarySum;
            }
        }
        Console.WriteLine(dec);
    }
}