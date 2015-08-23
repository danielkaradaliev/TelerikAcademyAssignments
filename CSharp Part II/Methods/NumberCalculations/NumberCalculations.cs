//Problem 15.* Number calculations
//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
using System;
using System.Collections.Generic;
class IntegerCalculations
{
    static T Product<T>(params T[] sequence)
    {
        if (sequence.Length > 0)
        {
            dynamic sum = 1;
            foreach (var item in sequence)
            {
                sum *= item;
            }
            return sum;
        }
        else
        {
            return default(T);
        }
    }
    static T Sum<T>(params T[] sequence)
    {
        dynamic sum = 0;
        foreach (var item in sequence)
        {
            sum += item;
        }
        return sum;
    }
    static T Average<T>(params T[] sequence)
    {
        dynamic sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum / sequence.Length;
    }
    static T Max<T>(params T[] sequence)
    {
        dynamic max = -9999999;                             //a small number
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] > max)
            {
                max = sequence[i];
            }
        }
        return max;
    }
    static T Min<T>(params T[] sequence)
    {
        dynamic min = 9999999;                              //a big number
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] < min)
            {
                min = sequence[i];
            }
        }
        return min;
    }
    static void Main()
    {
        Console.WriteLine("Min: {0}", Min(5, 6, 7, 8, 9, 10));
        Console.WriteLine("Max: {0}", Max(5, 6, 7, 8, 9, 10));
        Console.WriteLine("Average: {0}", Average(5.2, 6.9, 7.2, 8, 11.9, 10));     //use calculator
        Console.WriteLine("Sum: {0}", Sum(5.4, 6.5, 7.8, 8.1, 9.0, 10.4));
        Console.WriteLine("Product: {0}", Product(5, 6, 7, 8, 9, 10));
    }
}