namespace PrintStatisticsInCSharp
{
    using System;
    using System.Linq;

    public class StatisticsPrinter
    {
        public void PrintStatistics(double[] numbers)
        {
            double maximumNumber = numbers.Max();
            Console.WriteLine("Maximum: {0}", maximumNumber);
            double minimumNumber = numbers.Min();
            Console.WriteLine("Minimum: {0}", minimumNumber);
            int numbersCount = numbers.Length;
            double sumOfTheNumbers = numbers.Sum();
            double average = sumOfTheNumbers / numbersCount;
            Console.WriteLine("Average: {0}", average);
        }
    }
}
