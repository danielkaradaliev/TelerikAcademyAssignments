//Problem 2. IEnumerable extensions
//Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
//sum, product, min, max, average.
namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            dynamic sum = 0;
            foreach (T item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T Average<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            dynamic sum = 0;
            int count = 0;
            foreach (T item in collection)
            {
                sum += item;
                count++;
            }

            return sum / count;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            T product = (dynamic)1;
            foreach (T item in collection)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            T min = collection.Last();
            foreach (var item in collection)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            T max = collection.Last();
            foreach (var item in collection)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
