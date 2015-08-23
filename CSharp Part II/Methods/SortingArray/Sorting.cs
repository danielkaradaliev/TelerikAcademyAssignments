//Problem 9. Sorting array
//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
using System;
using System.Linq;
class Sorting
{
    static void SortArray(int[] arr)
    {
        int number = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    number = arr[j];
                    arr[j] = arr[i];
                    arr[i] = number;
                }
            }
        }
        Console.WriteLine("Sort array...");
        Console.Write("In  ascending order: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    number = arr[j];
                    arr[j] = arr[i];
                    arr[i] = number;
                }
            }
        }
        Console.Write("In descending order: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }

    static void MaximalElementInArray(int[] arr)
    {
        int maximalElement = arr.Max();
        Console.WriteLine("The maximal element in array is: " + maximalElement);
    }

    static void MaximalElementInPortiontOfArray(int[] arr, int firstIndex)
    {
        int maximalElementInPortion = 0;
        for (int i = firstIndex; i < arr.Length; i++)
        {
            if (arr[i] > maximalElementInPortion)
            {
                maximalElementInPortion = arr[i];
            }
        }
        Console.WriteLine("Max element in the portion of array is: " + maximalElementInPortion);
    }

    static void Main()
    {
        Console.Write("Enter array length: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] arr = new int[arrayLength];

        Console.WriteLine("Enter array elements...");
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter first index of the portion where you want to search: ");
        int firstIndex = int.Parse(Console.ReadLine());

        MaximalElementInArray(arr);
        MaximalElementInPortiontOfArray(arr, firstIndex);
        SortArray(arr);
    }
}