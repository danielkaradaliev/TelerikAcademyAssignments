//Problem 6. Maximal K sum
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
using System;
class MaximalKSum
{
    static void Main()
    {
        Console.Write("Length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ",i);
            arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        string bestSequence = "";
        int Sum = 0;
        int bestSum = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            string currentSeq = "";
            if (i + k > n)
            {
                break;
            }
            for (int j = i; j < i + k; j++)
            {
                Sum += arr[j];
                currentSeq = currentSeq + ' ' + arr[j];
            }
            if (Sum > bestSum)
            {
                bestSequence = currentSeq;
                bestSum = Sum;
            }
            Sum = 0;
        }
        Console.WriteLine(bestSequence);
        Console.WriteLine(bestSum);
    }
}