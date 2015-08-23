//Problem 24. Order words
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;
class OrderWords
{
    static void Main(string[] args)
    {
        //string input = "A random sentence with dsadas with some fsasds words that atahjsa don't make sence!";
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string[] letters = input.Split(new char[] { ' ', ',','.','?','!' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(letters);
        foreach (var word in letters)
        {
            Console.WriteLine(word);
        }
    }
}