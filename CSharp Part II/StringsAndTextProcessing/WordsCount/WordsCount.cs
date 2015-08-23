//Problem 22. Words count
//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class WordsCount
{
    static void Main()
    {
        //string input = "repeat repeat the words the as many times as times as times as you can times you words repeat";
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
        var dictionary = new Dictionary<string, int>();         //Very, very useful!
        foreach (var word in words)
        {
            if (dictionary.ContainsKey(word))
            {
                dictionary[word]++;
            }
            else
            {
                dictionary.Add(word, 1);
            }
        }
        foreach (var word in dictionary.OrderBy(key => key.Value))
        {
            Console.WriteLine("\"{0}\" is met {1} times", word.Key, word.Value);
        }
    }
}