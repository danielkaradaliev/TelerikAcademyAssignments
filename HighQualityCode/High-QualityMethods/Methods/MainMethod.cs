namespace Methods
{
    using System;

    internal class Main
    {
        internal static void Main()
        {
            Console.WriteLine(StaticMethods.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(StaticMethods.NumberToDigit(5));

            Console.WriteLine(StaticMethods.FindMax(5, -1, 3, 2, 14, 2, 3));

            StaticMethods.PrintAsNumber(1.3, "f");
            StaticMethods.PrintAsNumber(0.75, "%");
            StaticMethods.PrintAsNumber(2.30, "r");

            Console.WriteLine(StaticMethods.CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + StaticMethods.IsLineHorizontal(-1, 2.5));
            Console.WriteLine("Vertical? " + StaticMethods.IsLineVertical(3, 3));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
