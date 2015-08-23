//Problem 9. Frequent number
//Write a program that finds the most frequent number in an array.
//Example:
//input	                                        result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	        4 (5 times)
using System;
class FrequentNumber
{
    static void Main()
    {
        int CurrentNumber = 0;
        int CurrentTimes = 1;
        int number = 0;
        int times = 1;
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int temp, min;
        for (int i = 0; i < arr.Length; i++)
        {
            min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }
        for (int i = 0; i < arr.Length - 1; i++)
        {
            CurrentNumber = arr[i];
            if (arr[i] == arr[i + 1])
            {
                CurrentTimes++;
            }
            if (arr[i] != arr[i + 1])
            {
                CurrentTimes = 1;
            }
            if (CurrentTimes > times)
            {
                times = CurrentTimes;
                number = CurrentNumber;
            }
        }
        Console.Write("{0} ({1} times)", number, times);
    }
}