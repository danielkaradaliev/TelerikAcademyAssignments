namespace SimpleMaths
{
    using System;
    using System.Diagnostics;

    internal class MainProgram
    {
        internal static void Main()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            MathOperationPerformance.PerformanceTest(Opeartion.Addition);
            MathOperationPerformance.PerformanceTest(Opeartion.Subtracion);
            MathOperationPerformance.PerformanceTest(Opeartion.Multiplication);
            MathOperationPerformance.PerformanceTest(Opeartion.Division);
            stopWatch.Stop();

            // Estimated time: ~38 sec
            Console.WriteLine("\nElapsed time: {0}", stopWatch.Elapsed);
        }
    }
}