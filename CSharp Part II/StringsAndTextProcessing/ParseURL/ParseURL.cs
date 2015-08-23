//Problem 12. Parse URL
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Example:
//URL	                                                    Information
//http://telerikacademy.com/Courses/Courses/Details/212	    [protocol] = http [server] = telerikacademy.com [resource] = /Courses/Courses/Details/212
using System;
//using System.Text;
class ParseURL
{
    static void Main()
    {
        Console.Write("Enter URL: ");
        //string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        string url = Console.ReadLine();
        int i = 0;
        i = url.IndexOf(':');
        Console.WriteLine("[protocol] = {0}", url.Substring(0, i));
        url = url.Remove(0, i + 3);
        i = url.IndexOf('/');
        Console.WriteLine("[server] = {0}", url.Substring(0, i));
        url = url.Remove(0, i);
        Console.WriteLine("[resource] = {0}", url);
    }
}