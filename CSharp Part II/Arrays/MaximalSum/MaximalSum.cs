//Problem 8. Maximal sum
//Write a program that finds the sequence of maximal sum in given array.
//Example:
//input	                                result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	    2, -1, 6, 4
using System;
class MaximalSum
{
    static void Main()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int StartIndex = 0;
        int EndIndex = 0;
        int MaxSum = arr[0];
        int CurrentSum = arr[0];
        int CurrentIndex = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (CurrentSum > 0)
            {
                CurrentSum += arr[i];
            }
            else
            {
                CurrentSum = arr[i];
                CurrentIndex = i;
            }

            if (CurrentSum > MaxSum)
            {
                MaxSum = CurrentSum;
                StartIndex = CurrentIndex;
                EndIndex = i;
            }
        }
        for (int i = StartIndex; i < EndIndex; i++)
        {
            Console.Write("{0}, ",arr[i]);
        }
        Console.Write(arr[EndIndex]);
        Console.WriteLine();
    }
}