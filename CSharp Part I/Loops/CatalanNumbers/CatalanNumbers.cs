//Problem 8. Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
//Examples:
//n	    Catalan(n)
//0	    1
//5	    42
//10	16796
//15	9694845
using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double nPlusOne = n + 1;

        BigInteger nFactorial = 1;
        BigInteger nPlusOneFactorial = 1;
        BigInteger doubleNFactorial = 1;
        BigInteger result = 0;

        for (int i = 1; i <= 2 * n; i++)
        {
            doubleNFactorial *= i;

            if (i <= n)
            {
                nFactorial *= i;
            }
            if (i <= nPlusOne)
            {
                nPlusOneFactorial *= i;
            }
        }
        result = doubleNFactorial / (nPlusOneFactorial * nFactorial);
        Console.WriteLine("{0}", result);
    }
}