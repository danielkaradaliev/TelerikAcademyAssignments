//Problem 1. Odd lines
//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader ReadFile = new StreamReader("..//..//OddLines.cs");
        using (ReadFile)
        {
            int CurrentLine = 1;
            string line = ReadFile.ReadLine();
            while (line != null)
            {
                if (CurrentLine % 2 == 0)
                {
                    Console.WriteLine(line);
                }
                CurrentLine++;
                line = ReadFile.ReadLine();
            }
        }
        Console.WriteLine("Done!");
    }
}