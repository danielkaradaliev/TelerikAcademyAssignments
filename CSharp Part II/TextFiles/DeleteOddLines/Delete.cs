//Problem 9. Delete odd lines
//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.
using System;
using System.IO;
using System.Collections.Generic;
class Delete
{
    static void Main()
    {
        StreamReader ExampleFile = new StreamReader("..//..//ExampleFile.txt");     //This is the output file of the task "03.LineNumbers"!
        List<string> save = new List<string>();
        using (ExampleFile)
        {
            string fileReader = ExampleFile.ReadLine();
            int line = 1;
            while (fileReader != null)
            {
                if (line % 2 != 0)
                {
                    save.Add(fileReader);
                }
                line++;
                fileReader = ExampleFile.ReadLine();
            }
        }
        StreamWriter AgainExampleFile = new StreamWriter("..//..//ExampleFile.txt");
        using (AgainExampleFile)
        {
            for (int i = 0; i < save.Count; i++)
            {
                AgainExampleFile.WriteLine(save[i]);
            }
        }
        Console.WriteLine("Done!");
    }
}