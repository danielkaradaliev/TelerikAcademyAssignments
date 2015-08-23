//Problem 9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
//Examples:
//numbers	sum
//3	        90
//20	
//60	
//10	
//5	        6.5
//2	
//-1	
//-0.5	
//4	
//2	
//1	        1
//1	
using System;
class Sum
{
    static void Main()
    {
        double sum = 0, num;
        double n = double.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            num = double.Parse(Console.ReadLine());
            sum = sum + num;
        }
        Console.WriteLine();
        Console.WriteLine(sum);
    }
}