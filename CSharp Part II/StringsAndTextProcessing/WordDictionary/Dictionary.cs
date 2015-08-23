using System;
class Dictionary
{
    static void Main()
    {
        string input = ".NET - platform for applications from Microsoft\nCLR - managed execution environment for .NET\nnamespace - hierarchical organization of classes";
        //Console.Write("Enter a string: ");
        //string input = Console.ReadLine();
        Console.Write("Enter a word: ");
        string WordInput = Console.ReadLine();
        string[] SplittedWords = input.Split(new char[] { '\n', '-' });
        string searchedWord = WordInput + " ";

        for (int i = 0; i < SplittedWords.Length; i++)
        {
            if (string.Compare(searchedWord, SplittedWords[i], true) == 0)
            {
                Console.WriteLine(WordInput + " -" + SplittedWords[i + 1].ToString());
            }
        }
    }
}