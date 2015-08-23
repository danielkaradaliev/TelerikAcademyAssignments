//Problem 10. Find sum in array
//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:
//array	                    S	        result
//4, 3, 1, 4, 2, 5, 8	    11	        4, 2, 5
using System;
class FindSumInArray
{
    static void Main()
    {
        Console.Write("S= ");
        int S = int.Parse(Console.ReadLine());
        int i = 0;
        int Sum = 0;
        int br = 0;
        string result = "";
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        for (; i < arr.Length - 1;)
        {
            Sum += arr[i];
            result += arr[i] + ",";
            if (Sum == S)
            {
                break;
            }
            if(Sum > S)
            {
                result = "";
                br++;
                i = br;                 //if the sum of the integers gets bigger than S, we reset everything and start the next check from the next symbol
                Sum = 0;
            }
            else if (Sum < S)
            {
                i++;
            }
        }
        for (int j = 0; j < result.Length - 1;j++ )     //Prints the result without the last comma
        {
            Console.Write(result[j]);
        }
        Console.WriteLine();
    }
}