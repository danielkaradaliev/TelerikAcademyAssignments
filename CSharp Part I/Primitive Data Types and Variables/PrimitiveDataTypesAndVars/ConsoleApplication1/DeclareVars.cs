//Problem 1. Declare Variables
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
using System;
class DeclareVars
{
    static void Main()
    {
        ushort num1 = 52130;
        sbyte num2 = -115;
        uint num3 = 4825932;
        sbyte num4 = 97;
        short num5 = -10000;
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
        Console.WriteLine(num4);
        Console.WriteLine(num5);
    }
}