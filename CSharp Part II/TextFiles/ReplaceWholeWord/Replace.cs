//Problem 8. Replace whole word
//Modify the solution of the previous problem to replace only whole words (not strings).
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
                    OutputFile.WriteLine(System.Text.RegularExpressions.Regex.Replace(read, "\\bstart\\b", "finish"));
                    read = InputFile.ReadLine();
                }
            }
        }
        Console.WriteLine("Done!");
    }
}