//Problem 6. Save sorted names
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:
//InputFile.txt	        OutputFile.txt
//Ivan                  George
//Peter                 Ivan 
//Maria                 Maria
//George	            Peter
using System;
using System.IO;
using System.Collections.Generic;
class SaveSortedNames
{
    static void Main()
    {
        StreamReader InputFile = new StreamReader("..//..//InputFile.txt");
        List<string> arr = new List<string>();
        using (InputFile)
        {
            string nameReader = InputFile.ReadLine();
            while (nameReader != null)
            {
                arr.Add(nameReader);
                nameReader = InputFile.ReadLine();
            }
        }
        arr.Sort();
        StreamWriter OutputFile = new StreamWriter("..//..//OutputFile.txt", true);
        using (OutputFile)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                OutputFile.WriteLine(arr[i]);
            }
        }
        Console.WriteLine("Done!");
    }
}