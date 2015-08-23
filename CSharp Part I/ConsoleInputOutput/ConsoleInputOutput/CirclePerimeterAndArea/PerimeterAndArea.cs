//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
//Examples:
//r	    perimeter	area
//2	    12.57	    12.57
//3.5	21.99	    38.48
using System;
class PerimeterAndArea
{
    static void Main()
    {
        float pi = 3.141592f;
        float r = float.Parse(Console.ReadLine());
        float perimeter = 2 * pi * r;
        float area = pi * r * r;
        Console.WriteLine("Perimeter: {0:F2}",perimeter);
        Console.WriteLine("Area: {0:F2}",area);
    }
}