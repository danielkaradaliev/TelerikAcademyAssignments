//Problem 4. Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height.
//Examples:
//width	height	perimeter	area
//3	      4	      14	     12
//2.5	  3	      11         7.5
//5	      5	      20	     25
using System;
class Rectangles
{
    static void Main()
    {
        Console.Write("Enter width: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        float b = float.Parse(Console.ReadLine());
        float perimeter = 2 * a + 2 * b;
        float area = a * b;
        Console.WriteLine("Perimeter: {0}", perimeter);
        Console.WriteLine("Area: {0}",area);
    }
}