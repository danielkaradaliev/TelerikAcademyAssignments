//Problem 14. Quick sort
//Write a program that sorts an array of integers using the Quick sort algorithm.
using System;
using System.Collections.Generic;

namespace Primenumbers
{
    class MainClass
    {
        static void Main()
        {
            List<int> NoPrime = new List<int>();

            for (int x = 2; x < 10000; x++)
            {
                for (int y = x * 2; y < 10000; y = y + x)
                {
                    if (!NoPrime.Contains(y))
                    {
                        NoPrime.Add(y);
                    }
                }
            }

            for (int z = 2; z < 10000; z++)
            {
                if (!NoPrime.Contains(z))
                {
                    Console.WriteLine(z);
                }
            }
        }
    }
}