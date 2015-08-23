//Problem 16. Date difference
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days
using System;
using System.Globalization;
class DateDifference
    {
        static void Main()
        {
            Console.Write("Enter first date (in format dd.MM.yyyy): ");
            string FirstDate = Console.ReadLine();
            Console.Write("Enter second date (in the format dd.MM.yyyy): ");
            string SecondDate = Console.ReadLine();
            DateTime start = DateTime.ParseExact(FirstDate, "d.M.yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(SecondDate, "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Distance is {0} days", Math.Abs((end - start).TotalDays));
        }
    }