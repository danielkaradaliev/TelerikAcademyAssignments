//Problem 4. Triangle surface
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.
using System;
class TriangleSurface
{
    static void CalculateSurfaceBySideAndAltitude()
    {
        Console.Write("Enter side: ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Enter altitude: ");
        double altitude = double.Parse(Console.ReadLine());
        double area = (side * altitude) / 2;
        Console.WriteLine("The area is: {0}", area);
    }

    static void CalculateSurfaceByThreeSides()
    {
        Console.Write("Enter a : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        double p = (a + b + c) / 2;
        double area = (double)Math.Sqrt((double)(p * (p - a) * (p - b) * (p - c)));
        Console.WriteLine("The area is: {0}", area);
    }

    static void CalculateSurfaceByTwoSidesAndAngle()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the angle between the two sides in grad: ");
        double angle = double.Parse(Console.ReadLine());
        double sinusAngle = DegreeToRadian(angle);
        double area = (a * b * sinusAngle) / 2;
        Console.WriteLine("The area is: {0}", area);
    }

    static void Main()
    {
        bool check = true;
        Console.WriteLine("Calculate the surface of a triangle by given:");
        Console.WriteLine("1. Side and an altitude to it");
        Console.WriteLine("2. Three sides");
        Console.WriteLine("3. Two sides and an angle between them");
        while (check)
        {
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: CalculateSurfaceBySideAndAltitude(); check = false; break;
                case 2: CalculateSurfaceByThreeSides(); check = false; break;
                case 3: CalculateSurfaceByTwoSidesAndAngle(); check = false; break;
                default: Console.WriteLine("Invalid choise!Try Again!"); break;
            }
        }
    }
    static double DegreeToRadian(double angle)
    {
        return Math.PI * angle / 180.0;
    }
}