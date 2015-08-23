//Problem 12.* Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
using System;
using System.Collections.Generic;
class Randomize
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] Arr;
        List<int> uniquePos = new List<int>();  //List
        Arr = new int[n];
        Random randomGenerator = new Random();
        for (int i = 0; i < Arr.Length; i++)
        {
            int randomIndex = randomGenerator.Next(Arr.GetLowerBound(0), Arr.GetUpperBound(0) + 1);
            while (uniquePos.Contains(randomIndex)) //This is checks if the number has already been printed
            {
                randomIndex = randomGenerator.Next(Arr.GetLowerBound(0), Arr.GetUpperBound(0) + 1);
            }
            Arr[i] = randomIndex + 1;
            uniquePos.Add(randomIndex);
            Console.Write("{0} ",Arr[i]);
        }
        Console.WriteLine();
    }
}