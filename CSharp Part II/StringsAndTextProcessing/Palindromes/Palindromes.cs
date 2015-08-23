//Problem 20. Palindromes
//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
using System;
using System.Text.RegularExpressions;
using System.Linq;
class Palindromes
{
    static bool IsPalindrome(string word)
    {
        return word.ToCharArray().SequenceEqual(word.ToCharArray().Reverse());
    }
    static void Main()
    {
        //string input = "This ABBA text contains lamal hahah some jajajajaj random palindromes hohohoh";
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();
        MatchCollection words = Regex.Matches(input, @"\b\w+\b");
        Console.WriteLine("Result:");
        foreach (var word in words)
        {
            if (IsPalindrome(word.ToString()))
            {
                Console.WriteLine(word);
            }
        }
    }
}