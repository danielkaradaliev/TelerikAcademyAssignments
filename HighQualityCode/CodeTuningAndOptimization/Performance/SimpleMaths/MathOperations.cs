namespace SimpleMaths
{
    using System;
    using System.Diagnostics;

    public static class MathOperationPerformance
    {
        private const int IntegerValue = 1;
        private const long LongValue = 1L;
        private const float FloatValue = 1.0f;
        private const double DoubleValue = 1.0;
        private const decimal DecimalValue = 1.0M;
        private const int OperationCount = 100000000;
        private static Stopwatch stopWatch = new Stopwatch();

        public static void PerformanceTest(Opeartion operation)
        {
            Console.WriteLine("\n{0}\n", operation);

            int resultInt = IntegerValue;
            stopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (operation)
                {
                    case Opeartion.Addition:
                        resultInt += IntegerValue;
                        break;
                    case Opeartion.Subtracion:
                        resultInt -= IntegerValue;
                        break;
                    case Opeartion.Multiplication:
                        resultInt *= IntegerValue;
                        break;
                    case Opeartion.Division:
                        resultInt /= IntegerValue;
                        break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine("{0,-20}:{1} \t result: {2}", "Int", stopWatch.Elapsed, resultInt);
            stopWatch.Reset();

            long resultLong = LongValue;
            stopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (operation)
                {
                    case Opeartion.Addition:
                        resultLong += LongValue;
                        break;
                    case Opeartion.Subtracion:
                        resultLong -= LongValue;
                        break;
                    case Opeartion.Multiplication:
                        resultLong *= LongValue;
                        break;
                    case Opeartion.Division:
                        resultLong /= LongValue;
                        break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine("{0,-20}:{1} \t result: {2}", "Long", stopWatch.Elapsed, resultLong);
            stopWatch.Reset();

            float resultFloat = FloatValue;
            stopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (operation)
                {
                    case Opeartion.Addition:
                        resultFloat += FloatValue;
                        break;
                    case Opeartion.Subtracion:
                        resultFloat -= FloatValue;
                        break;
                    case Opeartion.Multiplication:
                        resultFloat *= FloatValue;
                        break;
                    case Opeartion.Division:
                        resultFloat /= FloatValue;
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
                switch (operation)
                {
                    case Opeartion.Addition:
                        resultDouble += DoubleValue;
                        break;
                    case Opeartion.Subtracion:
                        resultDouble -= DoubleValue;
                        break;
                    case Opeartion.Multiplication:
                        resultDouble *= DoubleValue;
                        break;
                    case Opeartion.Division:
                        resultDouble /= DoubleValue;
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
                switch (operation)
                {
                    case Opeartion.Addition:
                        resultDecimal += DecimalValue;
                        break;
                    case Opeartion.Subtracion:
                        resultDecimal -= DecimalValue;
                        break;
                    case Opeartion.Multiplication:
                        resultDecimal *= DecimalValue;
                        break;
                    case Opeartion.Division:
                        resultDecimal /= DecimalValue;
                        break;
                }
            }

            stopWatch.Stop();
            Console.WriteLine("{0,-20}:{1} \t result: {2}", "Decimal", stopWatch.Elapsed, resultDecimal);
            stopWatch.Reset();
        }
    }
}