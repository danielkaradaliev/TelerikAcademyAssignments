//Problem 5. Parse tags
//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
//az <upcase>sym</upcase> mnogo <upcase>prost</upcase>!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ParseTags
{
    static void Main()
    {
        Console.WriteLine("Input String:");
        string input = Console.ReadLine();
       // //string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
       // StringBuilder uppercaseText = new StringBuilder();
       // for (int i = 0; i < input.Length; i++)
       // {
       //     if (input[i] == '<')
       //     {
       //         i += 8;
       //         while (input[i] != '<')
       //         {
       //             uppercaseText.Append(input[i].ToString().ToUpper());
       //             i++;
       //         }
       //         i += 8;
       //     }
       //     else
       //     {
       //         uppercaseText.Append(input[i]);
       //     }
       // }
       // Console.WriteLine(uppercaseText.ToString());
        bool check = false;
        char ch = ' ';
        string currentString = "";
        string output = "";
        string[] arr = input.Split(ch);
        for(int i = 0;i<arr.Length;i++)
        {
            currentString = arr[i];
            if(currentString.StartsWith("<upcase>"))
            {
                check = true;
            }
            if (check)
            {
                currentString = currentString.ToUpper();
            }
            if (currentString.Contains("</UPCASE>"))
            {
                currentString = currentString.ToUpper();
                check = false;
            }
            //Console.WriteLine(arr[i]);
            currentString = currentString.Replace("<UPCASE>", "");
            currentString = currentString.Replace("</UPCASE>", "");
            //currentString = currentString.Trim();
            output += currentString + " ";
        }
        Console.WriteLine(output);
    }
}