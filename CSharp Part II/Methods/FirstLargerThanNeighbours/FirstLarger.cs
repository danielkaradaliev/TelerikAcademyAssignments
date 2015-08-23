//Problem 6. First larger than neighbours
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.
using System;
class FirstLarger
{
    static void BiggerNumber(int[] arr)
    {
        int ReturnedIndex = 0;
        if (arr.Length == 1)
        {
            Console.WriteLine("No neighbors");
            return;
        }
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                ReturnedIndex = i;
                break;
            }
        }
        Console.WriteLine("The index of the first number,bigger than its neighbours is {0} !", ReturnedIndex);

    }
    static void Main()
    {
        Console.WriteLine("Input Array:");
        Console.Write("Input array lenght:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Input elements!");
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        BiggerNumber(arr);
    }
}