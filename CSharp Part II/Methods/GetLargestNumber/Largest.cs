//Problem 2. Get largest number
//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
using System;
class Largest
{
    static int GetMax(int x,int y)
    {
        int max = 0;
        if(x>y)
        {
            max = x;
        }
        else
        {
            max = y;
        }
        return max;
    }
    static void Main()
    {
        Console.WriteLine("Input three integers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int max = GetMax(a, b);
        max = GetMax(max, c);
        Console.WriteLine("The greatest number is {0} !",max);
    }
}