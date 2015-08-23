//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
//Examples:
//x	       y	inside
//0	       1	true
//-2       0	true
//-1       2	false
//1.5     -1	true
//-1.5	 -1.5	false
//100	  -30	false
//0	       0	true
//0.2	 -0.8	true
//0.9	 -1.93	false
//1	      1.655	true
using System;
class Circle
{
    static void Main()
    {
       // while (true)                          //Uncomment for easier check
       // {                                     //Uncomment for easier check
            double x, y;
            Console.Write("x=");
            x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            y = double.Parse(Console.ReadLine());
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 2 * 2)       //Pythagoras
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
       // }                                     //Uncomment for easier check

    }
}