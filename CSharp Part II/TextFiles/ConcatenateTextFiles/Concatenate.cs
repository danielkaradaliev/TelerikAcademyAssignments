//Problem 2. Concatenate text files
//Write a program that concatenates two text files into another text file.
using System;
using System.IO;
class Concatenate
{
    static void Main()
    {
        StreamWriter OutputFile = new StreamWriter("..\\..\\OutputFile.txt");
        using (OutputFile)
        {
            StreamReader ExampleFile1 = new StreamReader("..\\..\\ExampleFile.txt");
            using (ExampleFile1)
            {
                string file1Reader = ExampleFile1.ReadLine();
                while (file1Reader != null)
                {

                    OutputFile.WriteLine(file1Reader);
                    file1Reader = ExampleFile1.ReadLine();
                }

            }
            StreamReader ExampleFile2 = new StreamReader("..\\..\\Concatenate.cs");
            using (ExampleFile2)
            {
                string file2Reader = ExampleFile2.ReadLine();
                while (file2Reader != null)
                {
                    OutputFile.WriteLine(file2Reader);
                    file2Reader = ExampleFile2.ReadLine();
                }
            }
        }
        Console.WriteLine("Done!");
    }
}