//Problem 1. StringBuilder.Substring
//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder
//and has the same functionality as Substring in the class String.
namespace StringBuilderExtension
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                output.Append(sb[i + index]);
            }

            return output;
        }
    }
}
