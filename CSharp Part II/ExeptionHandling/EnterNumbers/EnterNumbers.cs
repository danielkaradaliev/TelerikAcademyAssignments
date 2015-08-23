//Problem 2. Enter numbers
//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
using System;
class EnterNumbers
{
    static int ReadNumber(int start, int end)
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if ((number < start) || (number > end))
        {
            throw new Exception("Invalid range");
        }
        return number;
    }
    static void Main()
    {
        int[] a = new int[10];
        int start = 1;
        int end = 100;
        try
        {
            a[0] = ReadNumber(start, end);
            for (int i = 1; i < a.Length; i++)
            {
                start = a[i - 1];
                a[i] = ReadNumber(start, end);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}