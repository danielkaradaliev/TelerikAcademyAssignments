//Problem 11. Binary search
//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
using System;
class BinnarySearch
{
    static void Main()
    {
        int[] arr = { 1, 1, 1, 2, 5, 6, 8, 99, 100, 108 };  //sorted array
        int target = 2;
        int index = Array.BinarySearch(arr, target);
        Console.WriteLine(index);
    }
}