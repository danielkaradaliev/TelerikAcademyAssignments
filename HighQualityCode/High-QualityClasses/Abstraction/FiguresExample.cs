namespace Abstraction
{
    using System;

    internal class FiguresExample
    {
        public static void Main()
        {
            Circle circle = new Circle(5);

            Console.WriteLine("Circle");
            Console.WriteLine("Perimeter: {0}", circle.CalcPerimeter());
            Console.WriteLine("Surface: {0}", circle.CalcSurface());
            Console.WriteLine();

            Rectangle rect = new Rectangle(3, 4);

            Console.WriteLine("Rectangle");
            Console.WriteLine("Perimeter: {0}", rect.CalcPerimeter());
            Console.WriteLine("Surface: {0}", rect.CalcSurface());
            Console.WriteLine();
        }
    }
}