//Problem 7. Selection sort
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
using System;
class SelectionSort
{
    static void Main()
    {
        int[] arr = { 3,4,6,1,2,5,9,8,7 };      //The numbers from 1 to 10 in mixed order
        int temp, min;
        for (int j = 0; j < arr.Length; j++)
        {
            min = j;
            for (int k = j + 1; k < arr.Length; k++)
            {
                if (arr[k] < arr[min])
                {
                    min = k;
                }
            }
            temp = arr[min];
            arr[min] = arr[j];
            arr[j] = temp;
        }
        for (int i = 0; i < arr.Length-1; i++)  //Printing the sorted array
        {
            Console.Write("{0}, ",arr[i]);
        }
        Console.Write(arr[arr.Length-1]);
        Console.ReadLine();
    }
}