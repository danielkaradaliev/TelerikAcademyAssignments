//Problem 5. Larger than neighbours
//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
using System;
class Larger
{
    static void BiggerNumber(int position,int[] arr)
    {
        if (arr.Length == 1)
        {
            Console.WriteLine("No neighbors");
            return;
        }
        if ((position == 0) || (position == arr.Length-1))
        {
            Console.WriteLine("The number does not have two neighbours!");
            return;
        }
        if((position > 0) && (position < arr.Length - 1))
            {
                Console.WriteLine("The bigger number is: " + Math.Max(Math.Max(arr[position], arr[position + 1]), arr[position - 1]));
            }
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
        Console.Write("Check position:");
        int pos = int.Parse(Console.ReadLine());
        BiggerNumber(pos, arr);
    }
}