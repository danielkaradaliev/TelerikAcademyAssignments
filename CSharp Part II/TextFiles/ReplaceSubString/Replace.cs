//Problem 7. Replace sub-string
//Write a program that replaces all occurrences of the sub-string "start" with the sub-string "finish" in a text file.
//Ensure it will work with large files (e.g. 100 MB).
using System;
using System.IO;
class Replace
{
    static void Main()
    {
        StreamWriter OutputFile = new StreamWriter("..//..//OutputFile.txt");
        using (OutputFile)
        {
            StreamReader InputFile = new StreamReader("..//..//InputFile.txt");
            using (InputFile)
            {
                string read = InputFile.ReadLine();
                while (read != null)
                {
                    OutputFile.WriteLine(read.Replace("start", "finish"));
                    read = InputFile.ReadLine();
                }
            }
        }
        Console.WriteLine("Done!");
    }
}