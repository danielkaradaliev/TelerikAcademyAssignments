namespace AdvancedMaths
{
    using System;
    using System.Diagnostics;

    internal class MainProgram
    {
        internal static void Main()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            MathFunctionsPerformance.PerformanceTest(Function.SquareRoot);
            MathFunctionsPerformance.PerformanceTest(Function.NaturalLogarithm);
            MathFunctionsPerformance.PerformanceTest(Function.Sinus); 
            stopWatch.Stop();

            // Estimated time: ~48 sec
            Console.WriteLine("\nElapsed time: {0}", stopWatch.Elapsed);
        }
    }
}