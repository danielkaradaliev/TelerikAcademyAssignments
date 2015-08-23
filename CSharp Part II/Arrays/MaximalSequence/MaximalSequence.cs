//Problem 4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.
//Example:
//input	                            result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1	    2, 2, 2
using System;
class MaximalSequence
{
    static void Main()
    {
        int isFirstNumber = 0;
        int CurrentNumber = 0;
        int isFirst = 0;
        int br = 1;
        int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] == arr[i])
            {
                CurrentNumber = arr[i];
                br++;
            }
            if (br > isFirst)
            {
                isFirstNumber = CurrentNumber;
                isFirst = br;
            }
            else if (arr[i - 1] != arr[i])
            {
                br = 1;
            }
        }
        for (int i = 0; i < isFirst - 1; i++)
        {
            Console.Write("{0},", isFirstNumber);
        }
        Console.Write(isFirstNumber);
        Console.WriteLine();
    }
}