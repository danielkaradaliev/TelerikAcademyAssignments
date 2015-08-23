//Problem 17. Longest string
//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.
namespace LongestString
{
    using System;
    using System.Linq;

    public class LongestString
    {
        public static void Main()
        {
            string[] array = { "aaa", "bbbbbbbbbbbb","I am the longest string!", "oh no, I am the longets!", "no, you are not! I am the longest haha!" };

            string longest = TheLongestString(array);
            Console.WriteLine(longest);
        }

        public static string TheLongestString(string[] input)
        {
            string result = (from s in input
                             orderby s.Length descending
                             select s).FirstOrDefault();

            return result;
        }
    }
}
