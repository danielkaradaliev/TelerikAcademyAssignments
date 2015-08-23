namespace AdvancedMaths
{
    using System;
    using System.Diagnostics;

    public class MathFunctionsPerformance
    {
        private const float FloatValue = 10.0f;
        private const double DoubleValue = 10.0;
        private const decimal DecimalValue = 10.0M;
        private const int OperationCount = 100000000;
        private static Stopwatch stopWatch = new Stopwatch();

        public static void PerformanceTest(Function function)
        {
            Console.WriteLine("\n{0}\n", function);

            float resultFloat = FloatValue;
            stopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (function)
                {
                    case Function.SquareRoot:
                        resultFloat = (float)Math.Sqrt(FloatValue);
                        break;
                    case Function.NaturalLogarithm:
                        resultFloat = (float)Math.Log(FloatValue);
                        break;
                    case Function.Sinus:
                        resultFloat = (float)Math.Sin(FloatValue);
                        break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine("{0,-20}:{1} \t result: {2}", "Float", stopWatch.Elapsed, resultFloat);
            stopWatch.Reset();

            double resultDouble = DoubleValue;
            stopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (function)
                {
                    case Function.SquareRoot:
                        resultDouble = (double)Math.Sqrt(DoubleValue);
                        break;
                    case Function.NaturalLogarithm:
                        resultDouble = (double)Math.Log(DoubleValue);
                        break;
                    case Function.Sinus:
                        resultDouble = (double)Math.Sin(DoubleValue);
                        break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine("{0,-20}:{1} \t result: {2}", "Double", stopWatch.Elapsed, resultDouble);
            stopWatch.Reset();

            decimal resultDecimal = DecimalValue;
            stopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (function)
                {
                    case Function.SquareRoot:
                        resultDecimal = (decimal)Math.Sqrt((double)DecimalValue);
                        break;
                    case Function.NaturalLogarithm:
                        resultDecimal = (decimal)Math.Log((double)DecimalValue);
                        break;
                    case Function.Sinus:
                        resultDecimal = (decimal)Math.Sin((double)DecimalValue);
                        break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine("{0,-20}:{1} \t result: {2}", "Decimal", stopWatch.Elapsed, resultDecimal);
            stopWatch.Reset();
        }
    }
}