//Problem 13. Count words
//Write a program that reads a list of words from the file InputFileWords.txt and finds how many times each of the words is contained in another file InputFileTest.txt.
//The result should be written in the file OutputFile.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security;
class Count
{
    public static List<string> FileReader()
    {
        using (StreamReader InputFileWords = new StreamReader("..//..//InputFileWords.txt"))
        {
            List<string> words = new List<string>();
            for (string line; (line = InputFileWords.ReadLine()) != null; ) words.Add(line);
            return words;
        }
    }
    public static Dictionary<string, int> SameWordsSequences(List<string> words)
    {
        using (StreamReader InputFileTest = new StreamReader("..//..//InputFileTest.txt"))
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string line = InputFileTest.ReadLine();
            while (line != null)
            {
                string[] wordsOnLine = line.ToLower().Split(' ', '.', ';', ':');
                foreach (string word in wordsOnLine)
                {
                    if (words.Contains(word))
                    {
                        if (!dictionary.ContainsKey(word))
                        {
                            dictionary.Add(word, 1);
                        }
                        else ++dictionary[word];
                    }
                }
                line = InputFileTest.ReadLine();
            }
            return dictionary;
        }
    }
    public static void SaveResultToFile(Dictionary<string, int> dictionary)
    {
        using (StreamWriter OutputFile = new StreamWriter("..//..//OutputFile.txt"))
        {
            var sortedDictionary = (from d in dictionary
                                    orderby d.Value descending
                                    select d);

            foreach (var pair in dictionary)
            {
                OutputFile.WriteLine(pair.Key + " " + pair.Value);
            }
        }
    }
    static void Main()
    {
        try
        {
            List<string> words = FileReader();
            Dictionary<string, int> dictionary = SameWordsSequences(words);
            SaveResultToFile(dictionary);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Done!");
    }
}