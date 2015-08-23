//Problem 4. Compare text files
//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.
using System;
using System.IO;
class Compare
{
    static void Main()
    {
        StreamReader InputFile1 = new StreamReader("..//..//InputFile1.txt");
        int same = 0;
        int different = 0;
        using (InputFile1)
        {
            string CurrentLine1 = InputFile1.ReadLine();
            StreamReader InputFile2 = new StreamReader("..//..//InputFile2.txt");
            using (InputFile2)
            {
                string readerTwo = InputFile2.ReadLine();
                while (CurrentLine1 != null && readerTwo != null)
                {
                    if (CurrentLine1 == readerTwo)
                    {
                        same++;
                    }
                    if (CurrentLine1 != readerTwo)
                    {
                        different++;
                    }
                    CurrentLine1 = InputFile1.ReadLine();
                    readerTwo = InputFile2.ReadLine();
                }
            }
        }
        Console.WriteLine("Done!");
        Console.WriteLine("Same Lines: {0} ", same);
        Console.WriteLine("Different lines {0} ", different);
    }
}