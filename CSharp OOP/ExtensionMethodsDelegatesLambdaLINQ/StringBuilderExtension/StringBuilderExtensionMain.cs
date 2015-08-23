//Problem 1. StringBuilder.Substring
//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder
//and has the same functionality as Substring in the class String.
namespace StringBuilderExtension
{
    using System;
    using System.Text;

    class StringBuilderExtensionMain
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("ABCDEFGH");       //Some string
            Console.WriteLine("Enter index");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine(sb.Substring(index, length));
        }
    }
}
