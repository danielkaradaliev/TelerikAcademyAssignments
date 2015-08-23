//Problem 3. Compare char arrays
//Write a program that compares two char arrays lexicographically (letter by letter).
using System;
class CompareCharArrays
{
    static void Main()
    {
        char[] arr1 = new char[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("arr1[{0}] = ", i);
            arr1[i] = char.Parse(Console.ReadLine());
        }
        char[] arr2 = new char[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("arr2[{0}] = ", i);
            arr2[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            if (arr1[i] > arr2[i])
            {
                Console.WriteLine("{0} > {1}", arr1[i], arr2[i]);
            }
            else if (arr1[i] < arr2[i])
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