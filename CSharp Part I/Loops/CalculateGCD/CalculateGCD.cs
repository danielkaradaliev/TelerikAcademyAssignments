﻿//Problem 17.* Calculate GCD
//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).
//Examples:
//a	    b	    GCD(a, b)
//3	    2	    1
//60	40	    20
//5	    -15	    5
using System;
class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        while (a != 0 && b != 0)
        {
            int temp;
            temp = b;
            b = a % b;
            a = temp;
        }
        Console.WriteLine(a);
    }
}