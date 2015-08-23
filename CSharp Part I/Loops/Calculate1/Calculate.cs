//Problem 6. Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
//Examples:
//n	    k	    n! / k!
//5	    2	    60
//6	    5	    6
//8	    3	    6720
using System;
class Calculate
{
    static void Main()
    {
        double a = 0;
        int nfactorial = 1;
        int kfactorial = 1;
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                kfactorial *= i;
            }
            nfactorial *= i;
        }
        a = nfactorial / kfactorial;
        Console.WriteLine(a);
    }
}