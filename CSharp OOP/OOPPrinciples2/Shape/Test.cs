//Problem 1. Shapes
//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface
//of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
//Define class Square and suitable constructor so that at initialization height must be kept 
//equal to width and implement the CalculateSurface() method.
//Write a program that tests the behaviour of the CalculateSurface() method for different shapes 
//Square, Rectangle, Triangle) stored in an array.

namespace Shapes
{
    using System;
    using System.Collections.Generic;

    class ShapesTest
    {
        static void Main()
        {
            Shape[] shapesArray = {
                                      new Triangle(3,3),
                                      new Rectangle(8, 4),
                                      new Square(5,5)
                                  };

            foreach (var shape in shapesArray)
            {
                Console.WriteLine("{0} area: {1} m^2.",shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
