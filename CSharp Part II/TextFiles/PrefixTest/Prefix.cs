//Problem 11. Prefix "test"
//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Prefix
{
    static void Main()
    {
        using (StreamWriter OutputFile = new StreamWriter("..//..//OutputFile.txt"))
        {
            using (StreamReader InputFile = new StreamReader("..//..//InputFile.txt"))
            {
                string CurrentLine = InputFile.ReadLine();
                string holder = "\\btest\\w*\\b";
                while (CurrentLine != null)
                {
                    Regex rgx = new Regex(holder);
                    CurrentLine = rgx.Replace(CurrentLine, " ");
                    OutputFile.WriteLine(CurrentLine);
                    CurrentLine = InputFile.ReadLine();
                }
            }
        }
        Console.WriteLine("Done!");
    }
}