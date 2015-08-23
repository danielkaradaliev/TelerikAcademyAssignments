//Problem 18. Extract e-mails
//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class ExtraxtMails
{
        static List<string> Emails(string text)
    {
        List <string> emails = new List<string>();
        string[] email = text.Split(new char[]{ '"' ,' '}, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in email)
        {
            if (word.Contains("@"))
            {
                emails.Add(word);
            }
        }
        return emails;
    }
        static void Main()
        {
            //string input = "JustSomeRandomEmail@abv.bg";
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("The emails are:");
            Console.WriteLine(String.Join("\n", Emails(input)));
        }
}