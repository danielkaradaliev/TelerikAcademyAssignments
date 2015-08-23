//Problem 6. Quadratic Equation
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Examples:
//a	    b	 c	roots
//2	    5	-3	x1=-3; x2=0.5
//-1	3	 0	x1=3; x2=0
//-0.5	4	-8	x1=x2=4
//5	    2	 8	no real roots
using System;
class QuadraticEquation
{
    static void Main()
    {
        double x1,x2;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double D = (b * b) - (4 * a * c);
        if (D<0)
            Console.WriteLine("no real roots");
        else if (D==0)
        {
            x1 = (-b) / (2 * a);
            Console.WriteLine("x1=x2={0}",x1);
        }
        else
        {
            x1 = ((-b) - Math.Sqrt(D)) / (2 * a);
            x2 = ((-b) + Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("x1={0} x2={1}",x1,x2);
        }
    }
}