//Problem 9.* Binary floating-point
//Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
//Example:
//number	sign	exponent	mantissa
//-27,25	1	    10000011	10110100000000000000000
using System;
using System.Linq;
class BinaryFloatingPoint
{

    static string ConvertFloatingPointToBynary(float number)
    {
        char sign = number < 0 ? '1' : '0';

        if (number == 0)
        {
            return Convert.ToString(0, 2).PadLeft(32, '0');
        }
        else if (number < 0)
        {
            number = number * (-1);
        }

        int temp = BitConverter.ToInt32(BitConverter.GetBytes(number), 0);
        return sign + Convert.ToString(temp, 2);
    }
    static void Main()
    {
        Console.WriteLine("Enter a floating-point number: ");
        float decnum = float.Parse(Console.ReadLine());
        string binnum = ConvertFloatingPointToBynary(decnum);
        Console.WriteLine("Binary: {0}", binnum);
        Console.WriteLine("Sign: {0}", binnum[0]);
        Console.WriteLine("Exponent: {0}", binnum.Substring(1, 8));
        Console.WriteLine("Mantissa: {0}", binnum.Substring(9, binnum.Length - 9));
    }
}