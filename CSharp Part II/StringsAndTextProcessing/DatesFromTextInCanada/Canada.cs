//Problem 19. Dates from text in Canada
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.﻿
using System;
using System.Globalization;
using System.Text.RegularExpressions;
class Canada
{
    static void Main()
    {
        //string input = "I am some random string 26.02.2004 with some random dates 05.04.1999 and the last date is 23.09.2001 !";
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();
        foreach (Match item in Regex.Matches(input, @"\b[0-9]{1,2}.[0-9]{1,2}.[0-9]{2,4}"))
        {
            DateTime date;
            if (DateTime.TryParseExact(item.Value, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}