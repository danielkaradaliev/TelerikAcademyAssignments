//Problem 5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.
//Example:
//input	                    result
//3, 2, 3, 4, 2, 2, 4	    2, 3, 4
using System;
class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] arr = new int[] {3, 2, 3, 4, 2, 2, 4};
        int countElements = 1;
        int bestCountElement = 1;
        int bestElement = 0;
        int countMembers = 0;
        int last = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1] + 1)
            {
                last = arr[i];
                countElements++;
                if (countElements > bestCountElement)
                {
                    bestCountElement = countElements;
                    bestElement = arr[i];
                    countMembers = bestElement - bestCountElement + 1;
                }
            }
            else
            {
                countElements = 1;
            }
        }
        for (int i = countMembers; i <= bestElement; i++)
        {
            if (i == bestElement)
            {
                Console.Write(i);
            }
            else
            {
                Console.Write("{0}, ", i);
            }
        }
        Console.WriteLine();
    }
}