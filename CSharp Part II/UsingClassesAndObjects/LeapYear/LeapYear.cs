//Problem 1. Leap year
//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.
using System;
class LeapYear
{
    static void Main()
    {
        bool IsLeap = false;
        Console.Write("Check year: ");
        int input = int.Parse(Console.ReadLine());
        DateTime year = new DateTime(input, 1, 1);
        IsLeap = DateTime.IsLeapYear(year.Year);
        Console.WriteLine(IsLeap);
    }
}