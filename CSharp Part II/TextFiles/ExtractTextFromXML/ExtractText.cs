//Problem 10. Extract text from XML
//Write a program that extracts from given XML file all the text without the tags.
//Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
using System;
using System.IO;
class ExtractText
{
    static void Main()
    {
        using (StreamReader InputFile = new StreamReader("..//..//InputFile.txt"))
        {
            int ch = InputFile.Read();
            bool InTags = false;
            while (ch != -1)
            {
                if (ch == '>')
                {
                    InTags = true;
                }
                else if (ch == '<' || ch == '\r' || ch == '\n')
                {
                    InTags = false;
                }
                if (InTags && ch != '>')
                {
                    Console.Write((char)ch);
                }
                ch = InputFile.Read();
            }
        }
    }
}
