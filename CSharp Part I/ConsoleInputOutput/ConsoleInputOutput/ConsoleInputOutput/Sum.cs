//Problem 1. Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum.
//Examples:
//a	    b	    c	    sum
//3	    4	    11	    18
//-2	0	    3	    1
//5.5	4.5	    20.1	30.1
using System;
class Sum
{
    static void Main()
    {
        float a, b, c;
        Console.Write("a=");
        a = float.Parse(Console.ReadLine());
        Console.Write("b=");
        b = float.Parse(Console.ReadLine());
        Console.Write("c=");
        c = float.Parse(Console.ReadLine());
        Console.WriteLine(a+b+c);
    }
}