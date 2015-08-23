//Problem 5. Sort by string length
//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
using System;
class Sort
{
    static string[] sortArray(string[] input)
    {
        string[] sortedArray = new string[input.Length];
        Array.Sort(input, (x, y) => x.Length.CompareTo(y.Length));
        return input;
    }
    static void Main()
    {
        string[] n = { "Adsdasdasdadasdasd", "C", "CCdsad", "BBdd", "Buuy", "AAjhfg" };
        n = sortArray(n);
        foreach(var element in n)
        {
            Console.WriteLine(element);
        }
    }
}