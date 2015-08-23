//Problem 3. Line numbers
//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.
using System;
using System.IO;
class LineNumbers
    {
        static void Main()
        {
            StreamReader InputFile = new StreamReader("..\\..\\LineNumbers.cs");

            using (InputFile)
            {
                string CurrentLine = InputFile.ReadLine();
                StreamWriter OutputFile = new StreamWriter("..\\..\\OutputFile.txt");
                using (OutputFile)
                {
                    int CurrentLineNumber = 1;
                    while (CurrentLine != null)
                    {
                        OutputFile.WriteLine("{0}: {1}", CurrentLineNumber, CurrentLine);
                        CurrentLineNumber++;
                        CurrentLine = InputFile.ReadLine();
                    }
                }
            }
            Console.WriteLine("Done!");
        }
    }