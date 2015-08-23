//Problem 2. IEnumerable extensions
//Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
//sum, product, min, max, average.
namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    class IEnumerableExtensionsMain
    {
        static void Main()
        {
            var collection = new HashSet<double> { 5.2, 8, -3.14, 0, 55 };

            Console.WriteLine(collection.Sum());
            Console.WriteLine(collection.Product());
            Console.WriteLine(collection.Min());
            Console.WriteLine(collection.Max());
            Console.WriteLine(collection.Average());
        }
    }
}
