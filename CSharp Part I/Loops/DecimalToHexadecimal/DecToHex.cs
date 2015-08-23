//Problem 16. Decimal to Hexadecimal Number
//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:
//decimal	    hexadecimal
//254	        FE
//6883	        1AE3
//338583669684	4ED528CBB4
using System;
class DecToHex
{
    static void Main()
    {
        long decNum = long.Parse(Console.ReadLine());
        string hexNum = "";
        if (decNum == 0)
        {
            hexNum = "0";
        }
        else
        {
            while (decNum > 0)
            {
                long remain = decNum % 16;
                decNum /= 16;
                switch (remain)
                {
                    case 10: hexNum = "A" + hexNum; break;
                    case 11: hexNum = "B" + hexNum; break;
                    case 12: hexNum = "C" + hexNum; break;
                    case 13: hexNum = "D" + hexNum; break;
                    case 14: hexNum = "E" + hexNum; break;
                    case 15: hexNum = "F" + hexNum; break;
                    default: hexNum = remain + hexNum; break;
                }
            }
        }
        Console.WriteLine(hexNum);
    }
}
