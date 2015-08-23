//Problem 4. Appearance count
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
using System;
class Count
{
    static int check(int GivenNumber,int[]arr)
    {
        int br = 0;
        for(int i =0;i<arr.Length;i++)
        {
            if(arr[i] == GivenNumber)
            {
                br++;
            }
        }
        return br;
    }
    static void Main()
    {
        Console.WriteLine("Input Array:");
        Console.Write("Input array lenght:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int [n];
        int output = 0;
        Console.Write("Number to look for:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Input elements!");
        for(int i = 0;i<n;i++)
        {
            Console.Write("array[{0}] = ",i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        output = check(number, arr);
        Console.WriteLine("The number {0} is met {1} times in your array!",number,output);
    }
}