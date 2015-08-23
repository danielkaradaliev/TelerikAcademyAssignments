//Problem 5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.
//Examples:
//a	        b	    c	    biggest
//5	        2	    2	    5
//-2       -2	    1	    1
//-2	    4	    3	    4
//0	       -2.5	    5	    5
//-0.1     -0.5	   -1.1	   -0.1
using System;
class TheBiggest
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double flag;
        if (a > b)
        {
            flag = a;
            if (flag < c)
            {
                flag = c;
            }
        }
        else
        {
            flag = b;
            if (b < c)
            {
                flag = c;
            }
        }
        Console.WriteLine();
        Console.WriteLine(flag);
    }
}