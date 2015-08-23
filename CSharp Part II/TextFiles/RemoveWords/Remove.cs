//Problem 12. Remove words
//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
class Remove
{
    static List<string> ListOfWords()
    {
        List<string> words = new List<string>();

        using (StreamReader InputedListedWords = new StreamReader("..//..//InputedListedWords.txt"))
        {
            string line = InputedListedWords.ReadLine();
            while (line != null)
            {
                words.Add(line);
                line = InputedListedWords.ReadLine();
            }
        }
        return words;
    }
    static void Main()
    {
        try
        {
            using (StreamWriter OutputFile = new StreamWriter("..//..//OutputFile.txt"))
            {
                using (StreamReader InputFile = new StreamReader("..//..//InputFile.txt"))
                {
                    List<string> listOfWords = ListOfWords();
                    string line = InputFile.ReadLine();
                    while (line != null)
                    {
                        for (int i = 0; i < listOfWords.Count; i++)
                        {
                            line = line.Replace(listOfWords[i], "");
                        }
                        OutputFile.WriteLine(line);
                        line = InputFile.ReadLine();
                    }
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Done!");
    }
}