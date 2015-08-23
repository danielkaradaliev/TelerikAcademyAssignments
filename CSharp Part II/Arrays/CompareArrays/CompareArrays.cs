//Problem 2. Compare arrays
//Write a program that reads two integer arrays from the console and compares them element by element.
using System;
class CompareArrays
{
    static void Main()
    {
        int[] arr1 = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("arr1[{0}] = ", i);
            arr1[i] = int.Parse(Console.ReadLine());
        }
        int[] arr2 = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("arr2[{0}] = ", i);
            arr2[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for(int i = 0;i<5;i++)
        {
            if(arr1[i]>arr2[i])
            {
                Console.WriteLine("{0} > {1}",arr1[i],arr2[i]);
            }
            else if(arr1[i]<arr2[i])
            {
                Console.WriteLine("{0} < {1}", arr1[i], arr2[i]);
            }
            else
            {
                Console.WriteLine("{0} = {1}", arr1[i], arr2[i]);
            }
        }
    }
}