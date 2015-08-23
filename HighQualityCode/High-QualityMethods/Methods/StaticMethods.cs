namespace Methods
{
    using System;

    internal static class StaticMethods
    {
        internal static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.Error.WriteLine("Sides should be positive.");
                return -1;
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        internal static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            return "Invalid number!";
        }

        internal static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                return -1;
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }

            return elements[0];
        }

        internal static void PrintAsNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        internal static double CalculateDistance(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double pointXDistance = (secondPointX - firstPointX) * (secondPointX - firstPointX);
            double pointYDistance = (secondPointY - firstPointY) * (secondPointY - firstPointY);
            double distance = Math.Sqrt(pointXDistance + pointYDistance);

            return distance;
        }

        internal static bool IsLineVertical(double firstPointX, double secondPointX)
        {
            return firstPointX == secondPointX;
        }

        internal static bool IsLineHorizontal(double firstPointY, double secondPointY)
        {
            return firstPointY == secondPointY;
        }
    }
}
