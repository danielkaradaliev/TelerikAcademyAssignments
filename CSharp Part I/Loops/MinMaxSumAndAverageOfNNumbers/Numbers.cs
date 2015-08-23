//Problem 3. Min, Max, Sum and Average of N Numbers
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
//Example 1:
//input	output
//3     min = 1 
//2     max = 5 
//5     sum = 8 
//1	    avg = 2.67
//Example 2:
//input	    output
//2         min = -1 
//-1        max = 4 
//4	        sum = 3 
//          avg = 1.50
using System;
class Numbers
{
    static void Main()
    {
        int num;
        int flagmin = Int32.MaxValue;
        int flagmax = Int32.MinValue;
        int Sum = 0;
        double avrg = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            num = int.Parse(Console.ReadLine());
            if(num<flagmin)
            {
                flagmin = num;
            }
            if(num>flagmax)
            {
                flagmax = num;
            }
            Sum += num;
            avrg += num;
        }
        avrg = avrg / n;
        Console.WriteLine("min = {0}",flagmin);
        Console.WriteLine("max = {0}",flagmax);
        Console.WriteLine("sum = {0}",Sum);
        Console.WriteLine("avg = {0:0.00}",avrg);
    }
}